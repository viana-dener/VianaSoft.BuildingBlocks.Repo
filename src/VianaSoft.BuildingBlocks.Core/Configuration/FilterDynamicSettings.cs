using Microsoft.Extensions.DependencyInjection;
using VianaSoft.BuildingBlocks.Core.Filters;
using VianaSoft.BuildingBlocks.Core.Filters.Interfaces;
using VianaSoft.BuildingBlocks.Core.Filters.Interpreters;

namespace VianaSoft.BuildingBlocks.Core.Configuration
{
    public static class FilterDynamicSettings
    {
        public static void AddFilterDynamic(this IServiceCollection services)
        {
            services.AddSingleton<IFilterInterpreterFactory, FilterInterpreterFactory>();
            services.AddSingleton<IDynamicFilter, DynamicFilter>();
        }
    }
}
