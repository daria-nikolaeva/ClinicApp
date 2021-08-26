using ClinicScheduleApp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicScheduleApp.Server.Operations
{
    public static class ClinicOperations
    {
        public static async Task<List<Schedule>> GetAllSchedule(ClinicDBContext.ClinicDBContext db)
        {
            List<Schedule> schedules = db.Schedules.ToList<Schedule>();
           
                return schedules;
        }
    }
}
