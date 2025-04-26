using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Faktura.WepApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseController : ControllerBase
    {
        public string UserId => GetAuthenticatedUserId();

        /// <summary>
        /// Get user id info from user claim
        /// </summary>
        protected string GetAuthenticatedUserId()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userId = User.Claims.First(i => i.Type == "nameIdentifier").Value;
                return userId;
            }

            return string.Empty;
        }
    }
}