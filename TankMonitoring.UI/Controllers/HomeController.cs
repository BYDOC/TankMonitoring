using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TankMonitoring.Data.Models.ORM.context;
using TankMonitoring.UI.Models;

namespace TankMonitoring.UI.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly EPDK_TANKContext _context;
        public HomeController(EPDK_TANKContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Secret()
        {

            return View();
        }
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public IActionResult Configure()
        {
            return View();
        }
        


    }
}
