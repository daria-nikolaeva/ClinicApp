using ClinicScheduleApp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicScheduleApp.Server.ClinicDBContext
{
    public class ClinicDBContext:DbContext
    {
        public DbSet<Schedule> Schedules { get; set; }
        public ClinicDBContext(DbContextOptions<ClinicDBContext> options) : base(options)
        {

        }
    }
}
