using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.Entity
{
    [Table("TankModbusTable")]
    public partial class TankModbusTable
    {
        [Key]
        [Column("TankModbusID")]
        public int TankModbusId { get; set; }
        [Column("TankID")]
        public int? TankId { get; set; }
        public int? LevelAdr { get; set; }
        [Column("GOVAdr")]
        public int? Govadr { get; set; }
        [Column("NSVAdr")]
        public int? Nsvadr { get; set; }
        [Column("TOVAdr")]
        public int? Tovadr { get; set; }
        public int? MassAdr { get; set; }
        public int? DensityAdr { get; set; }
        public int? AvgTempAdr { get; set; }
        public int? StatusAdr { get; set; }
        public int? ErrorAdr { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
    }
}
