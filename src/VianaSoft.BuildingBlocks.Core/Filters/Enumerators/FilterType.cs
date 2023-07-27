using System.ComponentModel;

namespace VianaSoft.BuildingBlocks.Core.Filters.Enumerators
{
    public enum FilterType
    {
        [Description("Equals")]
        Equals,
        [Description("Contains")]
        Contains,
        [Description("Start With")]
        StartWith,
        [Description("Less Than")]
        LessThan,
        [Description("GreaterThan")]
        GreaterThan
    }
}
