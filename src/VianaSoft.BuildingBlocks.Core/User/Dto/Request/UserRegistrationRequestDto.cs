namespace VianaSoft.BuildingBlocks.Core.User.Dto.Request
{
    public class UserRegistrationRequestDto
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? UrlImage { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
