using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("Menuler")]
    public partial class Menuler
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string MenuBaslik { get; set; }
        public int? MenuId { get; set; }
        [StringLength(100)]
        public string Link { get; set; }
        [StringLength(100)]
        public string Class { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? Tarih { get; set; }
        public int? Kullanici { get; set; }
        public int? Sira { get; set; }
        public bool? GorunsunMu { get; set; }
    }
}
