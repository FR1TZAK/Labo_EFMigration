using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Passenger", Schema = "dbo")]
    [Index(nameof(DetailId), Name = "IX_Passenger_DetailID")]
    public partial class Passenger
    {
        public Passenger()
        {
            Bookings = new HashSet<Booking>();
        }

        public DateTime? Birthday { get; set; }
        [Column("DetailID")]
        public int? DetailId { get; set; }
        [Key]
        [Column("PersonID")]
        public int PersonId { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        [Column("EMail")]
        public string Email { get; set; }
        public DateTime? CustomerSince { get; set; }
        public bool? FrequentFlyer { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(DetailId))]
        [InverseProperty(nameof(Persondetail.Passengers))]
        public virtual Persondetail Detail { get; set; }
        [InverseProperty(nameof(Booking.Passenger))]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
