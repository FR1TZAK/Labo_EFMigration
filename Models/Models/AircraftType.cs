using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("AircraftType", Schema = "dbo")]
    public partial class AircraftType
    {
        public AircraftType()
        {
            Flights = new HashSet<Flight>();
        }

        [Key]
        [Column("TypeID")]
        public byte TypeId { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }

        [InverseProperty("AircraftType")]
        public virtual AircraftTypeDetail AircraftTypeDetail { get; set; }
        [InverseProperty(nameof(Flight.AircraftType))]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
