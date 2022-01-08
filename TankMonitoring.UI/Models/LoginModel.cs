using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TankMonitoring.UI.Models
{
    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public short IsActive { get; set; }
        public short UserType { get; set; }
        public string? OwnedTanks { get; set; }
    }
}
