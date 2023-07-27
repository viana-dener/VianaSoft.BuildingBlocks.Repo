using Microsoft.Extensions.DependencyInjection;
using VianaSoft.BuildingBlocks.Core.Validations.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Validations
{
    public class FactoryValidators<TModel> : IFactoryValidators<TModel>
    {
        private IServiceProvider Provider { get; set; }

        public FactoryValidators(IServiceProvider provider)
        {
            Provider = provider;
        }

        public IMyValidatorBase<TModel> Create(TModel model)
        {
            return Provider.GetService<IMyValidatorBase<TModel>>();
        }
    }
}
