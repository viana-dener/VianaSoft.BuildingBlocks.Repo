using VianaSoft.BuildingBlocks.Core.Filters.Interfaces;
using VianaSoft.BuildingBlocks.Core.Filters.Interpreters;

namespace VianaSoft.BuildingBlocks.Core.Filters.Extensions
{
    public static class InterpreterTypeExtensions
    {
        public static IFilterTypeInterpreter<TType> And<TType>(this IFilterTypeInterpreter<TType> left, IFilterTypeInterpreter<TType> right)
            => new AndInterpreter<TType>(left, right);
    }
}
