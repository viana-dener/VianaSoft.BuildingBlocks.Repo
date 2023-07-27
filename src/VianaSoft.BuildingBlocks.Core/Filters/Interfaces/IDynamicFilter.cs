using System.Linq.Expressions;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interfaces
{
    public interface IDynamicFilter
    {
        Expression<Func<TType, bool>> FromFiltroItemList<TType>(IReadOnlyList<FilterItem> filtroItems);
    }
}
