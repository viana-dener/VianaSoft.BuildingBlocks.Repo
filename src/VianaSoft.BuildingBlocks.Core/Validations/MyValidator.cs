using VianaSoft.BuildingBlocks.Core.Validations.Enumerators;
using VianaSoft.BuildingBlocks.Core.Validations.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Validations
{
    public class MyValidator<TModel> : IMyValidator<TModel>
    {
        private IFactoryValidators<TModel> Factory { get; set; }

        public MyValidator(IFactoryValidators<TModel> factory)
        {
            Factory = factory;
        }

        public bool IsValid(TModel modelo, ContextService context = ContextService.OtherContext)
            => Factory.Create(modelo).IsValid(modelo, context);
    }
}
