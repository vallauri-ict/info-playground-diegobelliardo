using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_OOP03
{
    internal class Studente
    {
        string nome, città;
        int[] voti;

        public Studente():this ("nomeProva", "cittàProva", new int[12])
        {
        }

        public Studente(string nome, string città, int[] voti)
        {
            this.nome = nome;
            this.città = città;
            this.voti = voti;
        }

        public void Set(string n, string c, int[] v)
        {
            nome = n;
            città = c;
            voti = v;
        }

        public void Get(out string n, out string c, out int[] v)
        {
            n = nome;
            c = città;
            v = voti;
        }
    }
}
