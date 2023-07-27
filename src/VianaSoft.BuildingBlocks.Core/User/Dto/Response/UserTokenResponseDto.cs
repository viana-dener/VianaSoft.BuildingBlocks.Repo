namespace VianaSoft.BuildingBlocks.Core.User.Dto.Response
{
    public class UserTokenResponseDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? UrlImage { get; set; }
        public IEnumerable<UserClaimResponseDto> Claims { get; set; } = Enumerable.Empty<UserClaimResponseDto>();
    }
}
