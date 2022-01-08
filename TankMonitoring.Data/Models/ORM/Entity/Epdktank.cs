﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Table("EPDKTanks")]
    public partial class Epdktank
    {
        [Key]
        [Column("SaabTankID")]
        public int SaabTankId { get; set; }
        [Column("TerminalID")]
        public int? TerminalId { get; set; }
        [Column("TankGroupID")]
        public int? TankGroupId { get; set; }
        [StringLength(100)]
        public string TankName { get; set; }
        [Column("TankNameEPDK")]
        [StringLength(100)]
        public string TankNameEpdk { get; set; }
        [Column("ProductID")]
        public int? ProductId { get; set; }
        public double? Capacity { get; set; }
        public double? Height { get; set; }
        [Column("isVisible")]
        public bool? IsVisible { get; set; }
        [Column("isVisibleForAdmin")]
        public bool? IsVisibleForAdmin { get; set; }
        public int? CustomsStatus { get; set; }
        public bool? Maintenance { get; set; }
        public double? AmbientTemp { get; set; }
        public bool? LimitedHour { get; set; }
        [StringLength(250)]
        public string LimitedHourDesc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
    }
}
