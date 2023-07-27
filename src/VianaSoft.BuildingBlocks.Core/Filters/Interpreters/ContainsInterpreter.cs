using System.Linq.Expressions;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interpreters
{
    public class ContainsInterpreter<TType> : FilterTypeInterpreter<TType>
    {
        public ContainsInterpreter(FilterItem filterItem) : base(filterItem)
        {
        }

        internal override Expression CreateExpression(MemberExpression property, ConstantExpression constant)
        {
            var method = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) });

            return Expression.Call(property, method, constant);
        }
    }
}
