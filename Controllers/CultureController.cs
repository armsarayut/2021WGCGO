using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;

namespace GoWMS.Server.Controllers
{
    [Route("[controller]/[action]")]
    public class CultureController : ControllerBase
    {
        public IActionResult SetCulture(string  culture, string redirecturi)
        {
            if (culture != null)
            {
                HttpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(
                        new RequestCulture(culture))
                    );
            }
            return LocalRedirect(redirecturi);
        }
    }
}
