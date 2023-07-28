using Microsoft.AspNetCore.Http;

namespace VianaSoft.BuildingBlocks.Core.Identity
{
    public class CustomAuthorization
    {
        public static bool ValidateUserClaims(HttpContext context, string claimType, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                   context.User.Claims.Any(x => x.Type == claimType && x.Value.Contains(claimValue));
        }
    }
}
