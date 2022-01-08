using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {
        public int Id { get; set; }
        public int? LabId { get; set; }
        [StringLength(100)]
        public string KullaniciAdi { get; set; }
        [StringLength(100)]
        public string KullaniciParola { get; set; }
        [StringLength(100)]
        public string Adi { get; set; }
        [StringLength(100)]
        public string Soyadi { get; set; }
        [StringLength(100)]
        public string KullaniciFotograf { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Telefon { get; set; }
        [Column(TypeName = "date")]
        public DateTime? KayitTarihi { get; set; }
        public int? KayitEden { get; set; }
    }
}
