using System;

namespace ViaggiWeb.Models
{
    public class ViaggioDto
    {
        public string NomeAutista { get; set; }
        public string CognomeAutista { get; set; }
        public float Costo { get; set; }
        public string CittaPartenza { get; set; }
        public string CittaArrivo { get; set; }
        public DateTime Data { get; set; }
        public string NomePasseggero { get; set; }
        public string CognomePasseggero { get; set; }
    }
}