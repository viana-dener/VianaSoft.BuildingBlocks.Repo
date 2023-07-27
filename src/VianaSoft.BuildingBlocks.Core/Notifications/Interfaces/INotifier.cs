using System.Net;
using VianaSoft.BuildingBlocks.Core.Notifications.Enumerators;

namespace VianaSoft.BuildingBlocks.Core.Notifications.Interfaces
{
    public interface INotifier
    {
        void Add(string message, bool notify = true, HttpStatusCode statusCode = HttpStatusCode.BadRequest, TypeError typeError = TypeError.Warning);
        bool HasNotifications { get; }
        Reply CustomResponse(Object result, HttpStatusCode expectedHttpCode = HttpStatusCode.OK);
    }
}
