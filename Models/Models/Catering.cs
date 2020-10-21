using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

#nullable disable

namespace Models.Models
{
    [Table("Catering", Schema = "dbo")]
    public class Catering
    {

        [Key]
        public int ID { get; set; }
        public string Company { get; set; }
        public string Meal { get; set; }

        public virtual Flight Flight { get; set; }
        public int FlightID { get; set; }


    }
}
