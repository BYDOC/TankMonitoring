using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("EPDKUsers")]
    public partial class Epdkuser
    {
        [Column("SaabUserID")]
        public int SaabUserId { get; set; }
        [StringLength(50)]
        public string SaabUser { get; set; }
        [StringLength(50)]
        public string UserPwd { get; set; }
        [Column("UType")]
        public short? Utype { get; set; }
        [Column("isActive")]
        public short? IsActive { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }
        public string OwnedTanks { get; set; }
    }
}
