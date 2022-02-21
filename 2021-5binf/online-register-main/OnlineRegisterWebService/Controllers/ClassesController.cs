using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineRegisterClassLibrary;
using OnlineRegisterClassLibrary.Models;

namespace OnlineRegisterWebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        // GET: api/Classes
        [HttpGet]
        public IEnumerable<Classroom> Get()
        {
            List<Classroom> classrooms = new List<Classroom>();
            DbTools dBTools = new DbTools();
            var data = dBTools.GetDataTable(@"SELECT * FROM Class").Rows;
            foreach (DataRow item in data)
            {
                classrooms.Add(new Classroom(Convert.ToInt32(item["Id"]), Convert.ToInt32(item["Year"]), item["Section"].ToString(), item["Specialization"].ToString()));
            }
            return classrooms;
        }

        // GET: api/Classes/5
        [HttpGet("{id}", Name = "GetClassroom")]
        public ActionResult<Classroom> Get(int id)
        {
            DbTools dBTools = new DbTools();
            var item = dBTools.GetDataTable($@"SELECT * FROM Class WHERE Id = {id};").Rows;
            if (item.Count > 0)
            {
                Classroom classroom = new Classroom(Convert.ToInt32(item[0]["Id"]), Convert.ToInt32(item[0]["Year"]), item[0]["Section"].ToString(), item[0]["Specialization"].ToString());
                return classroom;
            }
            else
                return NotFound();
        }

        // POST: api/Class
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Class/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
