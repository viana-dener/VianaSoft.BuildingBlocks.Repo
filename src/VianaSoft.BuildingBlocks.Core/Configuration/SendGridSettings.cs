namespace VianaSoft.BuildingBlocks.Core.Configuration
{
    public class SendGridSettings
    {
        public string? ApiKey { get; set; }
        public string? FromAddress { get; set; }
        public string? TemplateIdForgot { get; set; }
        public string? UrlRedirect { get; set; }
    }
}
