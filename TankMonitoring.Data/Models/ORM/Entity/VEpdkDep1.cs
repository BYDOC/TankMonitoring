using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    public partial class VEpdkDep1
    {
        [Column("DEP1ID")]
        public int Dep1id { get; set; }
        [Column("DEP1TankID")]
        public int? Dep1tankId { get; set; }
        [Column("TerminalID")]
        public int? TerminalId { get; set; }
        [StringLength(100)]
        public string TankName { get; set; }
        [Column("TankNameEPDK")]
        [StringLength(100)]
        public string TankNameEpdk { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        [Column("DEP1Zaman", TypeName = "datetime")]
        public DateTime? Dep1zaman { get; set; }
        [Column("DEP1ProductID")]
        public int? Dep1productId { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [Column("ProductGTIPNo")]
        [StringLength(100)]
        public string ProductGtipno { get; set; }
        [Column("DEP1Mass", TypeName = "numeric(12, 3)")]
        public decimal? Dep1mass { get; set; }
        [Column("DEP1Volume", TypeName = "numeric(12, 3)")]
        public decimal? Dep1volume { get; set; }
        [Column("DEP1Temperature", TypeName = "numeric(12, 3)")]
        public decimal? Dep1temperature { get; set; }
        [Column("DEP1Density", TypeName = "numeric(12, 3)")]
        public decimal? Dep1density { get; set; }
        [Column("DEP1Transferred")]
        public int? Dep1transferred { get; set; }
        [Column("DEP1TranferTime", TypeName = "datetime")]
        public DateTime? Dep1tranferTime { get; set; }
        [Column("DEP1Result")]
        [StringLength(250)]
        public string Dep1result { get; set; }
        [Column("DEP1SessionID")]
        [StringLength(50)]
        public string Dep1sessionId { get; set; }
        [Column("DEP1KayitID")]
        [StringLength(50)]
        public string Dep1kayitId { get; set; }
        [Column("DEP1Status")]
        public int? Dep1status { get; set; }
        [Column("isVisible")]
        public bool? IsVisible { get; set; }
        [Column("isVisibleForAdmin")]
        public bool? IsVisibleForAdmin { get; set; }
        public bool? Maintenance { get; set; }
        public bool? LimitedHour { get; set; }
        [StringLength(250)]
        public string LimitedHourDesc { get; set; }
    }
}
