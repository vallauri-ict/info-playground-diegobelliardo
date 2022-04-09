using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViaggiWeb.Models;

namespace ViaggiWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaggiController : ControllerBase
    {
        // GET: api/Viaggi
        [HttpGet]
        public IEnumerable<ViaggioDto> Get()
        {
            DbTools db = new DbTools();
            DataTable data = db.GetDataTable("SELECT a.nome as nomeAutista, a.cognome as cognomeAutista, v.costo, v.cittaPartenza, v.cittaArrivo, v.[data], p.nome as nomePasseggero, p.cognome as cognomePasseggero " +
                                             "FROM Viaggio v, Autisti a, Passeggeri p, Prenotazioni pr " +
                                             "WHERE v.idAutista = a.id_Autista " +
                                             "AND pr.id_Viaggio = v.id_Viaggio " +
                                             "AND pr.id_Utente = p.id_Utente " +
                                             "AND v.isPrenotabile = 1 " +
                                             "AND a.id_Autista = 2 " +
                                             "ORDER BY v.[data];");

            List<ViaggioDto> Viaggi = new List<ViaggioDto>();
            foreach (DataRow row in data.Rows)
                Viaggi.Add(DataRowToViaggio(row));

            return Viaggi;
        }

        // GET: api/Viaggi/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        ViaggioDto DataRowToViaggio(DataRow viaggio)
        {
            return new ViaggioDto()
            {
                NomeAutista = viaggio["nomeAutista"].ToString(),
                CognomeAutista = viaggio["cognomeAutista"].ToString(),
                Costo = float.Parse(viaggio["costo"].ToString()),
                CittaPartenza = viaggio["cittaPartenza"].ToString(),
                CittaArrivo = viaggio["cittaArrivo"].ToString(),
                Data = Convert.ToDateTime(viaggio["Data"]),
                NomePasseggero = viaggio["nomePasseggero"].ToString(),
                CognomePasseggero = viaggio["cognomePasseggero"].ToString(),
            };
        }
    }
}