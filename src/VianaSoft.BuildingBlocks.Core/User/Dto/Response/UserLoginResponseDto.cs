using Newtonsoft.Json;

namespace VianaSoft.BuildingBlocks.Core.User.Dto.Response
{
    public class UserLoginResponseDto
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? AccessToken { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public double ExpiresIn { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public UserTokenResponseDto UserToken { get; set; } = new UserTokenResponseDto();
    }
}
