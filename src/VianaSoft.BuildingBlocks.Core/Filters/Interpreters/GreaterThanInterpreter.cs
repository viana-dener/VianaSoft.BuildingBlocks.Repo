using System.Linq.Expressions;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interpreters
{
    public class GreaterThanInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public GreaterThanInterpreter(FilterItem filterItem) : base(filterItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
            => Expression.GreaterThan(property, constant);
    }
}
