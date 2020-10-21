using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("DepartureGrouping", Schema = "dbo")]
    public partial class DepartureGrouping
    {
        [Key]
        public string Departure { get; set; }
        public int FlightCount { get; set; }
    }
}
