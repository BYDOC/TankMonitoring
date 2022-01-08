using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Table("EPDK_DEP2")]
    public partial class EpdkDep2
    {
        [Key]
        [Column("DEP2ID")]
        public int Dep2id { get; set; }
        [Column("DEP2Zaman", TypeName = "datetime")]
        public DateTime? Dep2zaman { get; set; }
        [Column("DEP2CustomerID")]
        public int? Dep2customerId { get; set; }
        [Column("DEP2ProductID")]
        public int? Dep2productId { get; set; }
        [Column("DEP2CustomsStatusID")]
        public int? Dep2customsStatusId { get; set; }
        [Column("DEP2LastMassStock", TypeName = "numeric(12, 3)")]
        public decimal? Dep2lastMassStock { get; set; }
        [Column("DEP2Status")]
        public int? Dep2status { get; set; }
        [Column("DEP2Transferred")]
        public int? Dep2transferred { get; set; }
        [Column("DEP2TransferTime", TypeName = "datetime")]
        public DateTime? Dep2transferTime { get; set; }
        [Column("DEP2Result")]
        [StringLength(250)]
        public string Dep2result { get; set; }
        [Column("DEP2SessionID")]
        [StringLength(50)]
        public string Dep2sessionId { get; set; }
        [Column("DEP2KayitID")]
        [StringLength(50)]
        public string Dep2kayitId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
    }
}
