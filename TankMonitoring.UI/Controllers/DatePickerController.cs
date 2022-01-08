using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitoring.UI.Controllers
{
    public class DatePickerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
