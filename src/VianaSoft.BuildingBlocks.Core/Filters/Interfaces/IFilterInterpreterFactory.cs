using VianaSoft.BuildingBlocks.Core.Filters.Interpreters;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interfaces
{
    public interface IFilterInterpreterFactory
    {
        IFilterTypeInterpreter<TType> Create<TType>(FilterItem filterItem);
    }
}
