using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    public partial class TankTransaction
    {
        [Column("TankTransactionID")]
        public int TankTransactionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TankDate { get; set; }
        [Column("TankID")]
        public int? TankId { get; set; }
        [StringLength(50)]
        public string TankRefName { get; set; }
        [StringLength(50)]
        public string TankRefProduct { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? TankLevel { get; set; }
        [StringLength(20)]
        public string LevelUnit { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? AvgTemp { get; set; }
        [StringLength(20)]
        public string TempUnit { get; set; }
        [Column("TOV", TypeName = "numeric(12, 3)")]
        public decimal? Tov { get; set; }
        [Column("TOVUnit")]
        [StringLength(20)]
        public string Tovunit { get; set; }
        [Column("NSV", TypeName = "numeric(12, 3)")]
        public decimal? Nsv { get; set; }
        [Column("NSVUnit")]
        [StringLength(20)]
        public string Nsvunit { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? Density { get; set; }
        [StringLength(20)]
        public string DensityUnit { get; set; }
        [Column("WIA", TypeName = "numeric(12, 3)")]
        public decimal? Wia { get; set; }
        [Column("WIAUnit")]
        [StringLength(20)]
        public string Wiaunit { get; set; }
        [Column("CalcWIA", TypeName = "numeric(12, 3)")]
        public decimal? CalcWia { get; set; }
        [StringLength(20)]
        public string LevStatus { get; set; }
        [Column("NSVDiff", TypeName = "numeric(12, 3)")]
        public decimal? Nsvdiff { get; set; }
        [Column("VCF", TypeName = "numeric(12, 3)")]
        public decimal? Vcf { get; set; }
        [Column("AMBT", TypeName = "numeric(12, 3)")]
        public decimal? Ambt { get; set; }
        [Column("GOV", TypeName = "numeric(12, 3)")]
        public decimal? Gov { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? VaporPressure { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? Ullage { get; set; }
    }
}
