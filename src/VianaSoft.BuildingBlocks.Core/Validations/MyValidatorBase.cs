using FluentValidation;
using FluentValidation.Results;
using VianaSoft.BuildingBlocks.Core.Notifications.Interfaces;
using VianaSoft.BuildingBlocks.Core.Resources.Interfaces;
using VianaSoft.BuildingBlocks.Core.Validations.Enumerators;
using VianaSoft.BuildingBlocks.Core.Validations.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Validations
{
    public abstract class MyValidatorBase<TModel> : AbstractValidator<TModel>, IMyValidatorBase<TModel>
    {
        private INotifier Notifier { get; set; }
        private readonly ILanguageMessage _message;

        public MyValidatorBase(INotifier notifier, ILanguageMessage message)
        {
            Notifier = notifier;
            _message = message;
        }

        public override ValidationResult Validate(ValidationContext<TModel> context)
        {
            var name = typeof(TModel).Name;

            return context.InstanceToValidate == null
                ? new ValidationResult(new[] { new ValidationFailure(name, _message.NotNull()) })
                : base.Validate(context);
        }

        public abstract void ValidateAll(TModel modelo);

        public abstract void ToValidate(TModel modelo, ContextService contexto = ContextService.OtherContext);

        public void NotifyErrors(IList<ValidationFailure> erros)
        {
            foreach (var erro in erros)
            {
                Notifier.Add(erro.ErrorMessage);
            }
        }

        public bool IsValid(TModel modelo, ContextService context = ContextService.OtherContext)
          => ModelIsValid(modelo, context);

        private bool ModelIsValid(TModel modelo, ContextService context = ContextService.OtherContext)
        {
            ToValidate(modelo, context);
            var resultadoValidacao = Validate(modelo);
            NotifyErrors(resultadoValidacao.Errors);
            return resultadoValidacao.IsValid && !Notifier.HasNotifications;
        }
    }
}
