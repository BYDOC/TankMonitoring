using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("OPCExport")]
    public partial class Opcexport
    {
        [Column("OPCExportID")]
        public int OpcexportId { get; set; }
        [Column("TankID")]
        public int? TankId { get; set; }
        [StringLength(50)]
        public string TankRefName { get; set; }
        [Column("OPC_TankRefName")]
        [StringLength(250)]
        public string OpcTankRefName { get; set; }
        [Column("OPC_TankRefProduct")]
        [StringLength(250)]
        public string OpcTankRefProduct { get; set; }
        [Column("OPC_TankLevel")]
        [StringLength(250)]
        public string OpcTankLevel { get; set; }
        [Column("OPC_TOV")]
        [StringLength(250)]
        public string OpcTov { get; set; }
        [Column("OPC_GOV")]
        [StringLength(250)]
        public string OpcGov { get; set; }
        [Column("OPC_NSV")]
        [StringLength(250)]
        public string OpcNsv { get; set; }
        [Column("OPC_WIA")]
        [StringLength(250)]
        public string OpcWia { get; set; }
        [Column("OPC_CalcWIA")]
        [StringLength(250)]
        public string OpcCalcWia { get; set; }
        [Column("OPC_Density")]
        [StringLength(250)]
        public string OpcDensity { get; set; }
        [Column("OPC_NSVDiff")]
        [StringLength(250)]
        public string OpcNsvdiff { get; set; }
        [Column("OPC_AvgTemp")]
        [StringLength(250)]
        public string OpcAvgTemp { get; set; }
        [Column("OPC_VaporPressure")]
        [StringLength(250)]
        public string OpcVaporPressure { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
    }
}
