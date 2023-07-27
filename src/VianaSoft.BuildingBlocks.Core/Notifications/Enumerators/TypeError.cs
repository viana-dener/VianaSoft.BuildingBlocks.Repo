using System.ComponentModel;

namespace VianaSoft.BuildingBlocks.Core.Notifications.Enumerators
{
    public enum TypeError
    {
        [Description("Success")]
        Success,
        [Description("Information")]
        Information,
        [Description("Warning")]
        Warning,
        [Description("Error")]
        Error,
        [Description("Fatal")]
        Fatal
    }
}
