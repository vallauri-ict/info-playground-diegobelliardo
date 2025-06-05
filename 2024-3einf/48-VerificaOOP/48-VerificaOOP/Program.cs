using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48_VerificaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1=null, p2=null;
            try
            {
                p1 = new Persona("Luca", "Ambrogio", 25);
                p2 = new Persona("Stefano", "Bianchi", -3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            p1.Visualizza();

            Contatore c = Contatore.CreaContatore();
            Console.WriteLine($"Valore contatore: {c.Valore}");
            c.Incrementa();
            c.Incrementa();
            Console.WriteLine($"Valore contatore: {c.Valore}");


            List<Studente> lstStudenti = new List<Studente>();
            Dictionary<int, Studente> dicStudenti = new Dictionary<int, Studente>();
            //int id;
            Studente st=new Studente();
            int n = 0;

            while (n < 3)
            {
                do
                {
                    Console.Write("Inserisci l'ID: ");
                    st.id = Convert.ToInt32(Console.ReadLine());
                } while (dicStudenti.ContainsKey(st.id));
                Console.Write("Inserisci il Nome: ");
                st.nome = Console.ReadLine();
                Console.Write("Inserisci il Cognome: ");
                st.cognome = Console.ReadLine();

                lstStudenti.Add(st);
                dicStudenti.Add(st.id, st);
                n++;
            }
            Studente rStudente = lstStudenti.ElementAt(0);
            if (lstStudenti.Remove(lstStudenti.ElementAt(0)))
            {
                Console.WriteLine("Studente " + rStudente.id + " rimosso");
            }
            else
            {
                Console.WriteLine("Errore rimozione");
            }

            Console.ReadKey();
        }
    }
}
