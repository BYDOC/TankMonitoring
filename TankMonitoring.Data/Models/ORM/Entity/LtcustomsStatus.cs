using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("LTCustomsStatus")]
    public partial class LtcustomsStatus
    {
        [Column("CustomsStatusID")]
        public int CustomsStatusId { get; set; }
        [StringLength(50)]
        public string CustomsStatus { get; set; }
    }
}
