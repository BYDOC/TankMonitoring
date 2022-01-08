using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitoring.UI.Models
{
    public class OwnedTanksVM
    {
        public int TankId { get; set; }
        public List<string> OwnedTanks { get; set; }
    }
}
