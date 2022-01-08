using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    public partial class Customer
    {
        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(250)]
        public string CustomerFullName { get; set; }
        [StringLength(50)]
        public string LicenseNumber { get; set; }
        [StringLength(50)]
        public string TaxNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
    }
}
