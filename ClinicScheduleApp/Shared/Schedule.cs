using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicScheduleApp.Shared
{
    public class Schedule
    {
        public int SceduleId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        public string Description { get; set; }
    }
}
