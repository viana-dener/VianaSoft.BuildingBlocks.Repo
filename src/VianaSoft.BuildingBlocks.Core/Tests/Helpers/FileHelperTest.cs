using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace VianaSoft.BuildingBlocks.Core.Tests.Helpers
{
    public static class FileHelperTest
    {
        public static IFormFile GetInstance()
        {

            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write("sellerId;comissao");
            writer.Flush();
            stream.Position = 0;
            long baseStreamOffset = 0;
            long length = stream.Length;
            string name = "teste";
            string fileName = "teste.csv";

            var form = new FormFile(stream, baseStreamOffset, length, name, fileName)
            {
                Headers = GetHeaders()
            };
            return form;
        }

        private static HeaderDictionary GetHeaders()
        {
            return new HeaderDictionary() {
                new KeyValuePair<string, StringValues>("Content-Type", "text/csv")
            };
        }
    }
}
