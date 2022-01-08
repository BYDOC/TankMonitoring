using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    public partial class ReportSetting
    {
        [Column("ReportID")]
        public int ReportId { get; set; }
        [StringLength(500)]
        public string ReportVisCols { get; set; }
        [StringLength(250)]
        public string CompanyName { get; set; }
        [Column("ShowCalculatedWIA")]
        public int? ShowCalculatedWia { get; set; }
    }
}
