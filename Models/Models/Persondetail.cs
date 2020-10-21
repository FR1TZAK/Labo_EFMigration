using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Persondetail", Schema = "dbo")]
    public partial class Persondetail
    {
        public Persondetail()
        {
            Employees = new HashSet<Employee>();
            Passengers = new HashSet<Passenger>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public string Memo { get; set; }
        public byte[] Photo { get; set; }
        [StringLength(30)]
        public string Street { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(3)]
        public string Country { get; set; }
        [StringLength(8)]
        public string Postcode { get; set; }
        [StringLength(130)]
        public string Planet { get; set; }

        [InverseProperty(nameof(Employee.Detail))]
        public virtual ICollection<Employee> Employees { get; set; }
        [InverseProperty(nameof(Passenger.Detail))]
        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
