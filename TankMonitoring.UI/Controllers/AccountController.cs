using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TankMonitoring.Data.Models;
using TankMonitoring.Data.Models.ORM.context;
using TankMonitoring.UI.Models;

namespace TankMonitoring.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly EPDK_TANKContext _context;
        public AccountController(EPDK_TANKContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            return RedirectToAction("CardView", "Tank");
        }

        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Validate(LoginModel model, string returnUrl)
        {
            ViewData["returnUrl"] = returnUrl;
            if (returnUrl == "/")
            {
                returnUrl = "/tank/cardview";
            }
            var _isAdmin = _context.Epdkusers.FirstOrDefault(x=>x.SaabUser==model.UserName).Utype;
            string isAdmin = Convert.ToString(_isAdmin);

            //string _ownedTanks = "1,2,3,4"; //this will be retrieved from db
            string _ownedTanks = _context.Epdkusers.FirstOrDefault(x =>x.SaabUser==model.UserName).OwnedTanks;
            var isAuthenticated = _context.Epdkusers.FirstOrDefault(x => x.SaabUser == model.UserName && x.UserPwd == model.Password && x.IsActive == 1);
            if (isAuthenticated != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", model.UserName));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, model.UserName));
                claims.Add(new Claim(ClaimTypes.UserData,isAdmin)); //userdata is matched with utype parameter in db
                claims.Add(new Claim(type:"OwnedTanks", value:_ownedTanks));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                

               
               
                if (!String.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                  //return RedirectToAction("login");
                }
                return RedirectToAction("CardView","Tank");


            }

            return View("login");


        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("login");
        }
        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }



    }
}
