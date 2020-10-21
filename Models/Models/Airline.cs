using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Airline", Schema = "dbo")]
    public partial class Airline
    {
        public Airline()
        {
            Flights = new HashSet<Flight>();
        }

        [Key]
        [StringLength(3)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        public int? FoundingYear { get; set; }
        public bool? Bunkrupt { get; set; }

        [InverseProperty(nameof(Flight.AirlineCodeNavigation))]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
