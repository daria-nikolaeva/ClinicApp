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
            List<Schedule> schedules = new List<Schedule>();
            string sqlText="select * from public.Schedule";
            using (var command=db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandType =CommandType.Text;
                command.CommandText =sqlText;
                command.CommandTimeout = 5000;

                if (command.Connection.State==ConnectionState.Closed)
                {
                    await command.Connection.OpenAsync().ConfigureAwait(false);
                }
                using (var rd=await command.ExecuteReaderAsync().ConfigureAwait(false))
                {
                    if (rd.HasRows)
                    {
                        while (await rd.ReadAsync().ConfigureAwait(false))
                        {
                            Schedule schedule = new Schedule();
                            schedule.SceduleId = Int32.Parse(rd["Id"].ToString());
                            schedule.Date = DateTime.Parse(rd["Date"].ToString());
                            schedule.Time = DateTime.Parse(rd["Time"].ToString());
                            schedule.Description = rd["Description"].ToString();
                            schedules.Add(schedule);
                        }
                    }
                }
            }
                return schedules;
        }
    }
}
