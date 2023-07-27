using System.Net;
using VianaSoft.BuildingBlocks.Core.Notifications;

namespace VianaSoft.BuildingBlocks.Core.Tests.Mocks
{
    public class MockAnswerTest
    {
        #region Initialize
        public MockAnswerTest()
        {
        }
        #endregion

        #region Methods Public
        public static Reply MockAnswer(object result, int statusCode)
        {
            return new Reply
            {
                StatusCode = statusCode,
                Message = new MessageErrors
                {
                    Type = "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                    Title = "One or more validation errors occurred.",
                    Status = (int)HttpStatusCode.BadRequest,
                    TraceId = Guid.NewGuid().ToString(),
                    Errors = new List<ErrorNotification>()
                }
            };
        }

        #endregion 
    }
}
