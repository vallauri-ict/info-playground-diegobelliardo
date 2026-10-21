using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_M5E1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Studente> lstStudenti=new List<Studente>();
            Studente studente1=new Studente();

            studente1.Cognome = "Maffiotto";
            studente1.Nome = "Andrea";
            studente1.Eta = 17;

            lstStudenti.Add(studente1);

            Studente studente2 = new Studente();
            studente2.Cognome = "Student2";
            studente2.Nome = "Nome2";
            studente2.Eta = 16;

            lstStudenti.Add(studente2);

            Studente studente3 = new Studente();
            studente3.Cognome = "St3";
            studente3.Nome = "N3";
            studente3.Eta = 18;

            lstStudenti.Add(studente3);

            Studente studente4 = new Studente();
            studente4.Cognome = "Student4";
            studente4.Nome = "Nome4";
            studente4.Eta = 11;

            lstStudenti.Add(studente4);

            Studente studente5 = new Studente();
            studente5.Cognome = "St5";
            studente5.Nome = "N5";
            studente5.Eta = 18;

            lstStudenti.Add(studente5);

            foreach (var st in lstStudenti)
            {
                Console.WriteLine($"{st.Cognome} - {st.Nome}");
            }

            Studente stRimosso = new Studente();
            Console.WriteLine("Studenti inseriti!");
            if (lstStudenti.Remove(studente5))
            {
                Console.WriteLine("Studente rimosso\n");
            }
            else Console.WriteLine("Studente NON rimosso\n");

            foreach (var st in lstStudenti)
            {
                Console.WriteLine($"{st.Cognome} - {st.Nome}");
            }

            Console.WriteLine("Studente rimosso con RemoveAt\n");

            lstStudenti.RemoveAt(0);
            foreach (var st in lstStudenti)
            {
                Console.WriteLine($"{st.Cognome} - {st.Nome}");
            }

            Studente stud = lstStudenti.Find(st => st.Nome == "N3");
            Console.WriteLine($"Studente Trovato:\n{stud.Cognome}\n{stud.Nome}");
        }
    }
}
