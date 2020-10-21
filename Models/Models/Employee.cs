using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.Models
{
    [Table("Employee", Schema = "dbo")]
    [Index(nameof(DetailId), Name = "IX_Employee_DetailID")]
    [Index(nameof(SupervisorPersonId), Name = "IX_Employee_SupervisorPersonID")]
    public partial class Employee
    {
        public Employee()
        {
            FlightCopilots = new HashSet<Flight>();
            FlightPilots = new HashSet<Flight>();
            InverseSupervisorPerson = new HashSet<Employee>();
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
        public float Salary { get; set; }
        [Column("SupervisorPersonID")]
        public int? SupervisorPersonId { get; set; }
        public string PassportNumber { get; set; }
        [Required]
        public string Discriminator { get; set; }
        public DateTime? LicenseDate { get; set; }
        public int? FlightHours { get; set; }
        public string PilotLicenseType { get; set; }
        [StringLength(50)]
        public string FlightSchool { get; set; }

        [ForeignKey(nameof(DetailId))]
        [InverseProperty(nameof(Persondetail.Employees))]
        public virtual Persondetail Detail { get; set; }
        [ForeignKey(nameof(SupervisorPersonId))]
        [InverseProperty(nameof(Employee.InverseSupervisorPerson))]
        public virtual Employee SupervisorPerson { get; set; }
        [InverseProperty(nameof(Flight.Copilot))]
        public virtual ICollection<Flight> FlightCopilots { get; set; }
        [InverseProperty(nameof(Flight.Pilot))]
        public virtual ICollection<Flight> FlightPilots { get; set; }
        [InverseProperty(nameof(Employee.SupervisorPerson))]
        public virtual ICollection<Employee> InverseSupervisorPerson { get; set; }
    }
}
