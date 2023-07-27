using System.Linq.Expressions;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interpreters
{
    public class LessThanInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public LessThanInterpreter(FilterItem filterItem) : base(filterItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
            => Expression.LessThan(property, constant);
    }
}
