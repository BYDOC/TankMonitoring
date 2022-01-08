using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Table("EPDK_DR")]
    public partial class EpdkDr
    {
        [Key]
        [Column("DRID")]
        public int Drid { get; set; }
        [Column("DR_Zaman", TypeName = "datetime")]
        public DateTime? DrZaman { get; set; }
        [Column("DR_DepotID")]
        public int? DrDepotId { get; set; }
        [Column("DR_ProductID")]
        public int? DrProductId { get; set; }
        [Column("DR_CustomStatusID")]
        public int? DrCustomStatusId { get; set; }
        [Column("DR_LastMassStock", TypeName = "numeric(12, 3)")]
        public decimal? DrLastMassStock { get; set; }
        [Column("DR_Status")]
        public int? DrStatus { get; set; }
        [Column("DR_Transferred")]
        public int? DrTransferred { get; set; }
        [Column("DR_TransferTime", TypeName = "datetime")]
        public DateTime? DrTransferTime { get; set; }
        [Column("DR_Result")]
        [StringLength(250)]
        public string DrResult { get; set; }
        [Column("DR_SessionID")]
        [StringLength(50)]
        public string DrSessionId { get; set; }
        [Column("DR_KayitID")]
        [StringLength(50)]
        public string DrKayitId { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
    }
}
