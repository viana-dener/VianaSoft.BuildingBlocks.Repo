using FluentValidation.Results;
using VianaSoft.BuildingBlocks.Core.Validations.Enumerators;

namespace VianaSoft.BuildingBlocks.Core.Validations.Interfaces
{
    public interface IMyValidatorBase<TModel> : IMyValidator<TModel>
    {
        void ValidateAll(TModel modelo);
        void ToValidate(TModel modelo, ContextService context = ContextService.OtherContext);
        void NotifyErrors(IList<ValidationFailure> erros);
    }
}
