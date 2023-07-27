using VianaSoft.BuildingBlocks.Core.User.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace VianaSoft.BuildingBlocks.Core.User
{
    public class AspNetUser : IAspNetUser
    {
        #region Properties

        private readonly IHttpContextAccessor _accessor;

        #endregion

        #region Builders

        public AspNetUser(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        #endregion

        #region Public Methods

        public string Name => _accessor.HttpContext.User.Identity.Name != null ? _accessor.HttpContext.User.Identity.Name : "Homologação";

        public Guid GetUserId()
        {
            return IsAuthenticated() ? Guid.Parse(_accessor.HttpContext.User.GetUserId()) : Guid.Empty;
        }
        public string GetUserEmail()
        {
            return IsAuthenticated() ? _accessor.HttpContext.User.GetUserEmail() : "";
        }
        public string GetUserToken()
        {
            return IsAuthenticated() ? _accessor.HttpContext.User.GetUserToken() : "";
        }
        public string GetUserRefreshToken()
        {
            return IsAuthenticated() ? _accessor.HttpContext.User.GetUserRefreshToken() : "";
        }
        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }
        public bool HasRole(string role)
        {
            return _accessor.HttpContext.User.IsInRole(role);
        }
        public IEnumerable<Claim> GetClaims()
        {
            return _accessor.HttpContext.User.Claims;
        }
        public HttpContext GetHttpContext()
        {
            return _accessor.HttpContext;
        }

        #endregion
    }
}
