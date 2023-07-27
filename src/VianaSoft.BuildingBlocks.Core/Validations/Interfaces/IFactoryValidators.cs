namespace VianaSoft.BuildingBlocks.Core.Validations.Interfaces
{
    public interface IFactoryValidators<TModel>
    {
        IMyValidatorBase<TModel> Create(TModel model);
    }
}
