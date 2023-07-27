namespace VianaSoft.BuildingBlocks.Core.User.Dto.Request
{
    public class ResetPasswordRequestDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
    }
}
