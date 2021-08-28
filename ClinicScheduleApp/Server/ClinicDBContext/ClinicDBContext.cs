using ClinicScheduleApp.Shared;
using ClinicScheduleApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicScheduleApp.Server
{
    public class ClinicDBContext:DbContext
    {
       
        public ClinicDBContext(DbContextOptions<ClinicDBContext> options) : base(options)
        {

        }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
