using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TankMonitoring.Data.Models;
using TankMonitoring.Data.Models.ORM.context;
using TankMonitoring.UI.Enums;
using TankMonitoring.UI.Models;


namespace TankMonitoring.UI.Controllers
{

    public class TankController : Controller
    {
        private readonly EPDK_TANKContext _context;
        public TankController(EPDK_TANKContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            ClaimsPrincipal cp = this.User;
            var ownedTanks = cp.Claims.Where(c => c.Type == "ownedTanks").Select(c => c.Value).SingleOrDefault();
            List<LastStatusViewModel> model = _context.VTankLastStatuses.Where(x => x.TankId == 3).OrderBy(x => x.CreateDate).Select(x => new LastStatusViewModel()
            {
                Level = (float)x.TankLevel,
                Name = x.TankRefName,
                ProductName = x.ProductName,
                AvgTemp = (decimal)x.AvgTemp,
                FlowRate = (decimal)x.Nsvdiff,
                VCF = (decimal)x.Vcf,
                NSV = (decimal)x.Nsv,
                WIA = (decimal)x.Wia,
                TOV = (decimal)x.Tov,
                TankCurrentDate = x.TankDate,
                VaporPressure=(float)x.VaporPressure,
                GOV=(float)x.Gov
                

            }).ToList();

            return View(model);
        }


        [Authorize]
        public IActionResult TankHistorian(string TankNameF)
        {

            List<LastStatusViewModel> model = _context.VTankTransactions.Where(x => x.TankRefName == TankNameF).OrderByDescending(x => x.TankTransactionId).Take(1000).Select(x => new LastStatusViewModel()
            {
                Level = (float)x.TankLevel,
                Name = x.TankRefName,
                ProductName=x.ProductName,
                AvgTemp = (decimal)x.AvgTemp,
                FlowRate = (decimal)x.Nsvdiff,
                VCF = (decimal)x.Vcf,
                NSV = (decimal)x.Nsv,
                WIA = (decimal)x.Wia,
                TOV = (decimal)x.Tov,
                TankDate = x.TankDate,
                TankTransactionID = x.TankTransactionId,
                TankNameF = x.TankRefName,
                StartDateF = x.TankDate,
                EndDateF = x.TankDate

            }).ToList();

            return View(model);
        }
        [Authorize]
        public IActionResult HistFilter()
        {

            List<LastStatusViewModel> model = _context.VTankTransactions.OrderByDescending(x => x.TankTransactionId).Take(10000).Select(x => new LastStatusViewModel()
            {
                Level = (float)x.TankLevel,
                Name = x.TankRefName,
                ProductName = x.ProductName,
                AvgTemp = (decimal)x.AvgTemp,
                FlowRate = (decimal)x.Nsvdiff,
                VCF = (decimal)x.Vcf,
                NSV = (decimal)x.Nsv,
                WIA = (decimal)x.Wia,
                TOV = (decimal)x.Tov,
                TankDate = x.TankDate,
                TankTransactionID = x.TankTransactionId,
                TankNameF = x.TankRefName






            }).ToList();

            return View(model);
        }


        public IActionResult Details(int id)
        {
            LastStatusViewModel model = _context.VTankLastStatuses.Where(t => t.TankId == id).Select(t=> new LastStatusViewModel()
            {

                Level = (float)t.TankLevel,
                Name = t.TankName,
                ProductName=t.ProductName,
                FlowRate=t.Nsvdiff,
                AvgTemp=t.AvgTemp,
                VaporPressure= (float?)t.VaporPressure,
                Density= (double?)t.Density,
                VCF=t.Vcf,
                CapacityHeight= (float?)t.Capacity,
                TOV=t.Tov,
                GOV= (float?)t.Gov,
                WIA=t.Wia





            }).FirstOrDefault();
            
            return View(model);
        }
        public IActionResult AddTank()
        {
            return View();
        }
        public int[] SetRGBVal(int TankID)
        {
            var tankName = _context.VTankLastStatuses.Where(x => x.TankId == TankID);
            return null;
        }
        [Authorize]
        public IActionResult CardView()
        {
            
            string _ownedTanks = User.Claims.FirstOrDefault(c => c.Type == "OwnedTanks").Value;
            var ownedTanks = _ownedTanks.Split(',')
                 .Where(m => int.TryParse(m, out _))
                 .Select(m => int.Parse(m))
                 .ToList();
                 

            List<LastStatusViewModel> model = _context.VTankLastStatuses.Where(x => ownedTanks.Contains((int)x.TankId)).OrderBy(x => x.TankId).Select(x => new LastStatusViewModel((decimal)x.TankId)
            {
                Level = (float)x.TankLevel,
                Name = x.TankRefName,
                ProductName = x.ProductName,
                AvgTemp = (decimal)x.AvgTemp,
                FlowRate = (decimal)x.Nsvdiff,
                VCF = (decimal)x.Vcf,
                NSV = (decimal)x.Nsv,
                WIA = (decimal)x.Wia,
                TOV = (decimal)x.Tov,
                TankID = x.TankId,
                Density = (double?)x.Density,
                CapacityHeight = (float)x.Height,
                VaporPressure=(float)x.VaporPressure
                
            }).ToList();
            
            return View(model);
        }


    }
}
