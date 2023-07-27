namespace VianaSoft.BuildingBlocks.Core.Configuration
{
    public class ApiSettings
    {
        public string? ApiName { get; set; }
        public string? Secret { get; set; }
        public int ExpirationHours { get; set; }
        public int RefreshTokenExpiration { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
    }
}
