using VianaSoft.BuildingBlocks.Core.Validations.Enumerators;

namespace VianaSoft.BuildingBlocks.Core.Validations.Interfaces
{
    public interface IMyValidator<TModelo>
    {
        bool IsValid(TModelo modelo, ContextService context = ContextService.OtherContext);
    }
}
