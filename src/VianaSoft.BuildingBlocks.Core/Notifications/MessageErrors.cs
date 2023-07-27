namespace VianaSoft.BuildingBlocks.Core.Notifications
{
    public class MessageErrors
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string TraceId { get; set; }
        public dynamic Errors { get; set; }
    }
}
