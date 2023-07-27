using Microsoft.AspNetCore.Http;
using System.Net;

namespace VianaSoft.BuildingBlocks.Core.Middlewares
{
    public class ExceptionMiddleware
    {
        #region Properties

        private readonly RequestDelegate next;

        #endregion

        #region Builders

        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        #endregion

        #region Public Methods

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }

        }

        #endregion

        #region Private Methods

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ErrorMiddleware();

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development" ||
                Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Stage")
                error.Message = ex.Message;
            else
                error.Message = "There was a problem processing, please contact the system administrator!";

            error.StatusCode = context.Response.StatusCode > 400 ? context.Response.StatusCode.ToString() : "500";

            context.Response.StatusCode = context.Response.StatusCode > 400 ? context.Response.StatusCode : (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(error.ToString());
        }

        #endregion
    }
}
