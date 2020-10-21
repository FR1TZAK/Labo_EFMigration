using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Flight", Schema = "dbo")]
    [Index(nameof(AircraftTypeId), Name = "IX_Flight_AircraftTypeID")]
    [Index(nameof(AirlineCode), Name = "IX_Flight_AirlineCode")]
    [Index(nameof(CopilotId), Name = "IX_Flight_CopilotId")]
    [Index(nameof(Departure), nameof(Destination), Name = "IX_Flight_Departure_Destination")]
    [Index(nameof(PilotId), Name = "IX_Flight_PilotId")]
    [Index(nameof(FreeSeats), Name = "Index_FreeSeats")]
    public partial class Flight
    {
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int FlightNo { get; set; }
        [StringLength(50)]
        public string Departure { get; set; }
        [StringLength(50)]
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public bool? NonSmokingFlight { get; set; }
        public short Seats { get; set; }
        public short? FreeSeats { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        public string Memo { get; set; }
        public bool? Strikebound { get; set; }
        [Column(TypeName = "numeric(20, 8)")]
        public decimal? Utilization { get; set; }
        public byte[] Timestamp { get; set; }
        [StringLength(3)]
        public string AirlineCode { get; set; }
        public int PilotId { get; set; }
        public int? CopilotId { get; set; }
        [Column("AircraftTypeID")]
        public byte? AircraftTypeId { get; set; }
        public DateTime LastChange { get; set; }

        [ForeignKey(nameof(AircraftTypeId))]
        [InverseProperty("Flights")]
        public virtual AircraftType AircraftType { get; set; }
        [ForeignKey(nameof(AirlineCode))]
        [InverseProperty(nameof(Airline.Flights))]
        public virtual Airline AirlineCodeNavigation { get; set; }
        [ForeignKey(nameof(CopilotId))]
        [InverseProperty(nameof(Employee.FlightCopilots))]
        public virtual Employee Copilot { get; set; }
        [ForeignKey(nameof(PilotId))]
        [InverseProperty(nameof(Employee.FlightPilots))]
        public virtual Employee Pilot { get; set; }
        [InverseProperty(nameof(Booking.FlightNoNavigation))]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
