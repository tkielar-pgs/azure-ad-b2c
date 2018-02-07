using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PGS.Azure.ActiveDirectory.B2C.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [Authorize]
        public IActionResult Profile() => View(User.Claims);

        public IActionResult SignIn() => Challenge(new AuthenticationProperties
        {
            RedirectUri = Url.Action(nameof(Profile))
        });

        public IActionResult SignOut() => SignOut(new AuthenticationProperties
        {
            RedirectUri = Url.Action(nameof(Index))
        }, CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
    }
}
