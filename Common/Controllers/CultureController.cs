using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlazorDemos.Controllers
{

    [Route("[controller]/[action]")]
    public class CultureController : Controller
    {
        public IActionResult SetCulture(string culture, string redirectUri, string? currency)
        {
            if (culture != null)
            {
                HttpContext.Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(
                        new RequestCulture(culture)));
            }

            if (!String.IsNullOrEmpty(currency))
            {
                HttpContext.Response.Cookies.Append("currency", currency);
            }
            else
            {
                // Remove any existing currency override when none is provided
                HttpContext.Response.Cookies.Delete("currency");
            }

            return LocalRedirect(redirectUri);
        }
    }
}
