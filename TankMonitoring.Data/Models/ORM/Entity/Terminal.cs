using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Keyless]
    public partial class Terminal
    {
        [Column("TerminalID")]
        public int TerminalId { get; set; }
        [StringLength(50)]
        public string TerminalCode { get; set; }
        [StringLength(250)]
        public string TerminalName { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(100)]
        public string ContactName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
    }
}
