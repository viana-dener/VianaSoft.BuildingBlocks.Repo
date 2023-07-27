using VianaSoft.BuildingBlocks.Core.Filters.Extensions;
using VianaSoft.BuildingBlocks.Core.Filters.Interfaces;
using VianaSoft.BuildingBlocks.Core.Filters.Models;
using System.Linq.Expressions;

namespace VianaSoft.BuildingBlocks.Core.Filters
{
    public class DynamicFilter : IDynamicFilter
    {
        private readonly IFilterInterpreterFactory _factory;

        public DynamicFilter(IFilterInterpreterFactory factory)
        {
            _factory = factory;
        }

        public Expression<Func<TType, bool>> FromFiltroItemList<TType>(IReadOnlyList<FilterItem> filtroItems)
        {
            return filtroItems
                .Select(filtroItem => _factory.Create<TType>(filtroItem))
                .Aggregate((curr, next) => curr.And(next))
                .Interpret();
        }
    }
}
