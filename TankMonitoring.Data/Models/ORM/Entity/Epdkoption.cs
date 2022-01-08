using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    [Table("EPDKOptions")]
    public partial class Epdkoption
    {
        [Column("DTAOptionsID")]
        public int DtaoptionsId { get; set; }
        [StringLength(100)]
        public string ActiveCustomerName { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ProjectCreateDate { get; set; }
        [StringLength(100)]
        public string TerminalLocation { get; set; }
    }
}
