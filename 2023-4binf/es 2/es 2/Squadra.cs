using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_2
{
    public class Squadra
    {
        Random rnd=new Random();
        public string Nome;
        public string Città;
        public int Giocate;
        public int Vinte;
        public int Pareggiate;
        public int GolFatti;
        public int GolSubiti;
        public Squadra():this("Squadra Sconosciuta", "Città Sconosciuta")
        {
        }

        public Squadra(string nome, string città)
        {
            Nome = nome;
            Città = città;
            Giocate = 0;
            Vinte = 0;
            Pareggiate = 0;
            GolFatti = 0;
            GolSubiti = 0;
        }

        public void Vince(Squadra squadra)
        {
            squadra.Giocate++;
            squadra.Vinte++;
            squadra.GolFatti=GolFatti+ rnd.Next(1, 4);
        }

        public void Pareggia(Squadra squadra)
        {
            squadra.Giocate++;
            squadra.Pareggiate++;
            int gol = rnd.Next(0, 4);
            squadra.GolFatti = GolFatti + gol;
            squadra.GolSubiti = GolSubiti + gol;
        }

        
    }
}
