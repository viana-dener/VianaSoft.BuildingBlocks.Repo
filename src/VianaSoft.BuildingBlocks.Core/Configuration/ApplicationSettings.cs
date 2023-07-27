namespace VianaSoft.BuildingBlocks.Core.Configuration
{
    public class ApplicationSettings
    {
        public string? Application { get; set; }
        public string? Environment { get; set; }
        public ApiSettings ApiSettings { get; set; } = new ApiSettings();
    }
}
