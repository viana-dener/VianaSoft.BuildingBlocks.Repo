using VianaSoft.BuildingBlocks.Core.Notifications.Enumerators;

namespace VianaSoft.BuildingBlocks.Core.Notifications
{
    public class ErrorNotification
    {
        public TypeError TypeError { get; set; }
        public IList<string> Message { get; private set; } = new List<string>();

        public ErrorNotification(string message, TypeError typeError = TypeError.Warning)
        {
            Message.Add(message);
        }
    }
}
