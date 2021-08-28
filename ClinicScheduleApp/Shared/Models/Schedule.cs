using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicScheduleApp.Shared.Models
{
   [Table("Schedule")]
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTimeStart { get; set; }
        [Required]
        public DateTime DateTimeEnd { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
