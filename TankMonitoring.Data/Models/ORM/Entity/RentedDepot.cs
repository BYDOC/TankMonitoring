using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    public partial class RentedDepot
    {
        [Key]
        [Column("RentedDepotID")]
        public int RentedDepotId { get; set; }
        [StringLength(50)]
        public string DepotName { get; set; }
        [StringLength(250)]
        public string DepotCompanyName { get; set; }
        [StringLength(50)]
        public string DepotLicenseNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
    }
}
