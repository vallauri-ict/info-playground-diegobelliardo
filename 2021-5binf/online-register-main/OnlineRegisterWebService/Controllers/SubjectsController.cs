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
    public class SubjectsController : ControllerBase
    {
        // GET: api/Subjects
        [HttpGet]
        public IEnumerable<Subject> Get()
        {
            List<Subject> subjects = new List<Subject>();
            DbTools dBTools = new DbTools();
            var data = dBTools.GetDataTable(@"SELECT * FROM Subject");
            foreach (DataRow item in data.Rows)
            {
                Subject materia = new Subject(Convert.ToInt32(item["Id"]), item["Description"].ToString(), Convert.ToBoolean(item["IsPeculiar"]));
                subjects.Add(materia);
            }
            return subjects;
        }

        // GET: api/Subjects/5
        [HttpGet("{id}", Name = "GetSubject")]
        public ActionResult<Subject> Get(int id)
        {
            DbTools dBTools = new DbTools();
            var item = dBTools.GetDataTable($@"SELECT * FROM Subject WHERE Id = {id};").Rows;
            if (item.Count > 0)
            {
                Subject subject = new Subject(Convert.ToInt32(item[0]["Id"]), item[0]["Description"].ToString(), Convert.ToBoolean(item[0]["IsPeculiar"]));
                return subject;
            }
            else
                return NotFound();

        }

        // POST: api/Subject
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Subject/5
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
