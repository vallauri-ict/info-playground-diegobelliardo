using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutistiController : ControllerBase
    {

        DBTools dBTools = new DBTools();
        // GET: api/Autisti
        [HttpGet]
        public List<AutistaDTO> Get()
        {
            List<AutistaDTO> autisti = new List<AutistaDTO>();
            var data = dBTools.GetDataTable("SELECT * FROM Autisti");
            foreach (DataRow item in data.Rows)
            {
                autisti.Add(ConvertToAutista(item));

            }
            return autisti;
        }

        private AutistaDTO ConvertToAutista(DataRow item)
        {
            AutistaDTO autista = new AutistaDTO();
            autista.Id = Convert.ToInt32(item["id_Autista"]);
            autista.Nome = item["nome"].ToString();
            autista.Cognome = item["cognome"].ToString();
            autista.Telefono = item["telefono"].ToString();
            autista.Email = item["email"].ToString();
            autista.Fotografia = item["fotografia"].ToString();
            autista.DatiAuto = item["datiAuto"].ToString();
            autista.scadPatente = Convert.ToDateTime(item["scadPatente"]);
            return autista;

        }


        // GET: api/Autisti/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Autisti
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Autisti/5
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
