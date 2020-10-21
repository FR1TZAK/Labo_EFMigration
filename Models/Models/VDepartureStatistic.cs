using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("V_DepartureStatistics", Schema = "dbo")]
    public partial class VDepartureStatistic
    {
        [Key]
        public string Departure { get; set; }
        public int FlightCount { get; set; }
    }
}
