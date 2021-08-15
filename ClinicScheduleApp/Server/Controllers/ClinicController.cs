using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicScheduleApp.Shared;
using Microsoft.AspNetCore.Mvc;
using ClinicScheduleApp.Server.ClinicDBContext;
using ClinicScheduleApp.Server.Operations;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClinicScheduleApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly ClinicDBContext.ClinicDBContext _db;
        public ClinicController(ClinicDBContext.ClinicDBContext db)
        {
            _db = db;
        }
        // GET: api/<ClinicController>
        [HttpGet]
        public IEnumerable<Schedule> Get()
        {
           List<Schedule> schedules = ClinicOperations.GetAllSchedule(_db).Result;
            return  schedules;
        }

        // GET api/<ClinicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClinicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClinicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClinicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
