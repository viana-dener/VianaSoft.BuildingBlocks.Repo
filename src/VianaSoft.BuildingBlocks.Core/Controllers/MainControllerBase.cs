using Microsoft.AspNetCore.Mvc;
using System.Net;
using VianaSoft.BuildingBlocks.Core.Notifications.Interfaces;

namespace VianaSoft.BuildingBlocks.Core.Controllers
{
    [ApiController]
    public class MainControllerBase : ControllerBase
    {
        private readonly INotifier _notifier;

        protected MainControllerBase(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected IActionResult CustomResponse(object value)
        {
            try
            {
                var resposta = _notifier.CustomResponse(value);
                return StatusCode(resposta.StatusCode, resposta.Message);
            }
            catch (ArgumentException ex)
            {
                return ExceptionResult(ex, HttpStatusCode.BadRequest);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex, HttpStatusCode.InternalServerError);
            }
        }

        protected IActionResult ExceptionResult(Exception ex, HttpStatusCode statusCode, bool notify = false, string code = "", string message = "")
        {
            var erroDescricao = string.IsNullOrEmpty(message)
                ? $"{ex?.Message?.ToString()} - {ex?.InnerException?.Message.ToString()}"
                : message;

            _notifier.Add(erroDescricao, notify, statusCode);

            var resposta = _notifier.CustomResponse(null, statusCode);
            return StatusCode(resposta.StatusCode, resposta.Message);
        }

        protected bool LogError(Exception ex)
        {
            _notifier.Add(ex.Message, true, HttpStatusCode.InternalServerError);
            return true;
        }
    }
}
