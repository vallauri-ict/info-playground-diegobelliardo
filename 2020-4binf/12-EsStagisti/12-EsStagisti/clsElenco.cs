using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_EsStagisti
{
    sealed class clsElenco
    {
        List<clsAlunno> elenco;

        public clsElenco()
        {
            elenco = new List<clsAlunno>();
        }

        public void inserisci(clsAlunno a)
        {
            elenco.Add(a);
        }

        public void VisualizzaDGV(DataGridView dgv)
        {
            dgv.DataSource = typeof(List<>);
            // permette l'import secondo gli attributi della lista
            dgv.DataSource = elenco;
            // riempie il DGV
        }

        public int OreAzienda(string nomeA)
        {
            int oreTotAzienda = 0;

            foreach (clsAlunno a in elenco)
            {
                if (a is clsStagista)
                {
                    clsStagista s = a as clsStagista;  // clsStagista s = (clsStagista)a;
                    if (s.Azienda == nomeA)
                    {
                        oreTotAzienda += Convert.ToInt32(s.Ore);
                    }
                }
            }

            return oreTotAzienda;
        }

        public void cancella()
        {
            if (elenco.Count == 0)
                throw new Exception("Cancellazione negata, lista vuota");
            else
                elenco.RemoveAt(elenco.Count - 1);
        }

        public void cancella(int posizione)
        {
            posizione--;
            //Verifico l'esistenza
            if (elenco.Count == 0)
            {
                throw new Exception("Cancellazione negata, lista vuota");
            }
            else if (posizione < 0 || posizione > elenco.Count - 1)
                throw new Exception("Posizione non valida");
            else
                elenco.RemoveAt(posizione);
        }
    }
}
