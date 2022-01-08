using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Table("EPDKProducts")]
    public partial class Epdkproduct
    {
        [Key]
        [Column("ProductID")]
        public int ProductId { get; set; }
        [StringLength(100)]
        public string ProductName { get; set; }
        [Column("ProductGTIPNo")]
        [StringLength(100)]
        public string ProductGtipno { get; set; }
        [Column(TypeName = "numeric(12, 3)")]
        public decimal? RefDensity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("EPDKUser")]
        public int? Epdkuser { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
    }
}
