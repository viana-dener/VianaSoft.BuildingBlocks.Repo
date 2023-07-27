﻿using VianaSoft.BuildingBlocks.Core.Filters.Interfaces;
using VianaSoft.BuildingBlocks.Core.Filters.Models;

namespace VianaSoft.BuildingBlocks.Core.Filters.Interpreters
{
    public class FilterInterpreterFactory : IFilterInterpreterFactory
    {
        public IFilterTypeInterpreter<TType> Create<TType>(FilterItem filterItem)
        {
            switch (filterItem.FilterType)
            {
                case FilterTypeConstants.Equals:
                    return new EqualsInterpreter<TType>(filterItem);
                case FilterTypeConstants.Contains:
                    return new ContainsInterpreter<TType>(filterItem);
                case FilterTypeConstants.GreaterThan:
                    return new GreaterThanInterpreter<TType>(filterItem);
                case FilterTypeConstants.LessThan:
                    return new LessThanInterpreter<TType>(filterItem);
                case FilterTypeConstants.StartsWith:
                    return new StartsWithInterpreter<TType>(filterItem);

                default:
                    throw new ArgumentException($"the filter type {filterItem.FilterType} is invalid");
            }
        }
    }
}
