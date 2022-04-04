using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class AutistaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Fotografia { get; set; }
        public string DatiAuto { get; set; }
        public DateTime scadPatente { get; set; }

        public AutistaDTO()
        {
        }

        public AutistaDTO(int id, string nome, string cognome, string telefono, string email, string fotografia, string datiAuto, DateTime scadPatente)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            Telefono = telefono;
            Email = email;
            Fotografia = fotografia;
            DatiAuto = datiAuto;
            this.scadPatente = scadPatente;
        }
    }
}
