using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Serilog.Context;
using System.Net;
using VianaSoft.BuildingBlocks.Core.Extensions;
using VianaSoft.BuildingBlocks.Core.Notifications.Enumerators;
using VianaSoft.BuildingBlocks.Core.Notifications.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Notifications
{
    public class Notifier : INotifier
    {
        #region Properties
        private readonly ILogger<Notifier> _logger;
        private readonly IHttpContextAccessor _context;
        #endregion

        #region Builders
        public Notifier(ILogger<Notifier> logger, IHttpContextAccessor context)
        {
            _logger = logger;
            _context = context;
        }

        #endregion

        #region Public Methods

        public void Add(string message, bool notify = true, HttpStatusCode statusCode = HttpStatusCode.BadRequest, TypeError typeError = TypeError.Warning)
        {
            if (notify)
                Notifications.Add(new ErrorNotification(message, typeError));

            LoginNotification(message, typeError);
        }

        public Boolean HasNotifications => Notifications.Any();
        public Reply CustomResponse(Object result, HttpStatusCode expectedHttpCode = HttpStatusCode.OK)
        {
            return CreateAnswer(result, expectedHttpCode);
        }
        #endregion

        #region Private Methods
        private Reply CreateAnswer(object result, HttpStatusCode httpStatusCode)
        {
            var statusCode = GetStatusCode(httpStatusCode);

            return new Reply
            {
                StatusCode = (int)statusCode,
                Message = !HasNotifications ? global::VianaSoft.BuildingBlocks.Core.Notifications.Notifier.CreateMessage(result) : CreateMessageErrors(result)
            };
        }
        private IList<ErrorNotification> Notifications { get; set; } = new List<ErrorNotification>();
        private static Message CreateMessage(Object result)
        {
            var mensagem = new Message
            {
                Status = (int)HttpStatusCode.OK,
                Result = result
            };

            return mensagem;
        }
        private MessageErrors CreateMessageErrors(Object result)
        {
            var mensagem = new MessageErrors
            {
                Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                Title = "One or more validation errors occurred.",
                Status = (int)HttpStatusCode.BadRequest,
                TraceId = _context.HttpContext.TraceIdentifier,
                Errors = HasNotifications ? Notifications : null
            };

            return mensagem;
        }
        private void LoginNotification(string message, TypeError? typeError = null)
        {
            var correlationId = ExtensionMethods.GetCorrelationId(_context.HttpContext.Request.Headers);

            using (LogContext.PushProperty("CorrelationId", correlationId))
            {
                switch (typeError)
                {
                    case TypeError.Information:
                        _logger.LogInformation(message);
                        break;
                    case TypeError.Success:
                        _logger.LogInformation($"{correlationId} - {message}");
                        break;
                    case TypeError.Warning:
                        _logger.LogWarning($"{correlationId} - {message}");
                        break;
                    case TypeError.Error:
                        _logger.LogError($"{correlationId} - {message}");
                        break;
                    default:
                        _logger.LogInformation(message);
                        break;
                }
            }
        }
        private HttpStatusCode GetStatusCode(HttpStatusCode expectedHttpCode)
        {
            if (HasNotifications)
            {
                return Notifications.FirstOrDefault().TypeError switch
                {
                    TypeError.Error or TypeError.Fatal => HttpStatusCode.InternalServerError,
                    TypeError.Information or TypeError.Warning => HttpStatusCode.BadRequest,
                    _ => HttpStatusCode.BadRequest,
                };
            }

            return expectedHttpCode;
        }


        #endregion
    }
}
