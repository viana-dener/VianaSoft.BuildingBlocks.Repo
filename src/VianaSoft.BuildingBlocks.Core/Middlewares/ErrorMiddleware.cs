using Newtonsoft.Json;

namespace VianaSoft.BuildingBlocks.Core.Middlewares
{
    public class ErrorMiddleware
    {
        public string StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
