using System.Linq.Expressions;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interfaces
{
    public interface IFilterTypeInterpreter<TType>
    {
        Expression<Func<TType, bool>> Interpret();
    }
}
