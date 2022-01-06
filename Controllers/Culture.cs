using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Localization;

namespace GoWMS.Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Culture : ControllerBase
    {
        public ActionResult SetCultured()
        {
            IRequestCultureFeature culture = HttpContext.Features.Get<IRequestCultureFeature>();
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture((new string[] { "en-US", "th-TH" }.Where(s => s != culture.RequestCulture.Culture.Name).FirstOrDefault()))));
            return Redirect("/");
        }
    }
}
