using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Booking", Schema = "dbo")]
    [Index(nameof(PassengerId), Name = "IX_Booking_PassengerID")]
    public partial class Booking
    {
        [Key]
        public int FlightNo { get; set; }
        [Key]
        [Column("PassengerID")]
        public int PassengerId { get; set; }

        [ForeignKey(nameof(FlightNo))]
        [InverseProperty(nameof(Flight.Bookings))]
        public virtual Flight FlightNoNavigation { get; set; }
        [ForeignKey(nameof(PassengerId))]
        [InverseProperty("Bookings")]
        public virtual Passenger Passenger { get; set; }
    }
}
