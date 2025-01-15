using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confronto_ordinamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool semiordinato = false, ordinato=false;
            int n;

            Titolo("Confronto tra algoritmi di ordinamento", "Su insieme disordinato", ConsoleColor.Cyan, ConsoleColor.Black);
            CalcolaValori(10, semiordinato,ordinato);
            CalcolaValori(10000, semiordinato,ordinato);
            CalcolaValori(50000, semiordinato, ordinato);

            Console.WriteLine("\n Confornto su insieme disordinato terminato \n Premere invio per andare avanti");

            Console.ReadKey();
            Console.Clear();

            semiordinato=true;

            Titolo("Confronto tra algoritmi di ordinamento", "Su insieme parzialmenteordinato ", ConsoleColor.Cyan, ConsoleColor.Black);
            CalcolaValori(10,semiordinato, ordinato);
            CalcolaValori(10000, semiordinato, ordinato);
            CalcolaValori(50000, semiordinato, ordinato);

            Console.WriteLine("\n Confornto su insieme parzialmenteordinato terminato \n Premere invio per andare avanti");

            Console.ReadKey();
            Console.Clear();
            
            semiordinato = false;
            ordinato = true;

            Titolo("Confronto tra algoritmi di ordinamento", "Su insieme ordinato", ConsoleColor.Cyan, ConsoleColor.Black);
            CalcolaValori(10, semiordinato, ordinato);
            CalcolaValori(10000, semiordinato, ordinato);
            CalcolaValori(50000, semiordinato, ordinato);

            Console.WriteLine("\n Confornto su insieme ordinato terminato \n Il programma è finito");

            Console.ReadKey();
        }

        private static void CalcolaValori(int n,bool semiord, bool ordinato)
        {
            //VARIBILE CHE E' COME UN CRONOMETRO   
            Stopwatch sw = new Stopwatch();
            Titolo($"ordinamento di {n.ToString("N0")} elementi |   PER SELEZIONE |      PER SCAMBIO |   PER SCAMBIO SPECIALE", " ", ConsoleColor.Magenta, ConsoleColor.Black);

            // CARCO VETTORE NON ORDINATO
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];
            clsvettori.Caricavetdisordinato(a,semiord,n, ordinato);
            a.CopyTo(b, 0);
            a.CopyTo (c, 0);

            //ORDINAMENTO PER SELEZIONE
            long selPassi = 0, selConfronti = 0, selScambi = 0, selTicks = 0, selMillis=0;
            sw.Start();
            clsvettori.OrdinaPerSelezione(a, ref selPassi, ref selConfronti, ref selScambi);
            sw.Stop();
            selTicks = sw.ElapsedTicks;
            selMillis = sw.ElapsedMilliseconds;

            //ORDINAMENTO PER SCAMBIO
            long scaPassi = 0, scaConfronti = 0, scaScambi = 0, scaTicks = 0, scaMillis;
            sw.Restart();
            clsvettori.OrdinaPerScambio(b, ref scaPassi, ref scaConfronti, ref scaScambi);
            sw.Stop();
            scaTicks = sw.ElapsedTicks;
            scaMillis = sw.ElapsedMilliseconds;

            //SCAMBIO SPECIALE 
            long scaSPassi = 0, scaSConfronti = 0, scaSScambi = 0, scaSTicks = 0, scaSMillis;
            sw.Restart();
            clsvettori.OrdinaPerScambioSpeciale(c, ref scaSPassi, ref scaSConfronti, ref scaSScambi, n);
            sw.Stop();
            scaSTicks = sw.ElapsedTicks;
            scaSMillis = sw.ElapsedMilliseconds;

            //SCRIVO I VALORI
            ScrivoValori("Numero di passi", selPassi, scaPassi, scaSPassi);
            ScrivoValori("Numero di confronti", selConfronti, scaConfronti, scaSConfronti);
            ScrivoValori("Numero di scambi", selScambi, scaScambi, scaSScambi);
            ScrivoValori("Numero di tempo in ticks", selTicks, scaTicks, scaSTicks);
            ScrivoValori("Numero di tempo in nsec", selMillis, scaMillis, scaSMillis);
        }
        private static void ScrivoValori(string descr, long selValore, long scaValore, long scaSValore)
        {
            Console.WriteLine(
                "|" + descr.PadLeft(35)+
                "|" + selValore.ToString("N0").PadLeft(17)+
                "|" + scaValore.ToString("N0").PadLeft(17)+
                "|" + scaSValore.ToString("N0").PadLeft(26) + "|"
                );
            disegnariga();
        }

        private static void Titolo(string titolo, string sotto_titolo, ConsoleColor colorebg, ConsoleColor colortxt)
        {
            int lunghezza = 100;
            Console.BackgroundColor = colorebg;
            Console.ForegroundColor = colortxt;
            disegnariga();
            int spazio = (lunghezza - titolo.Length) / 2;
            Console.WriteLine("|".PadRight(spazio) + titolo + "|".PadLeft(spazio));
            if (sotto_titolo.Length > 0)
            {
                spazio = (lunghezza - sotto_titolo.Length) / 2;
                Console.WriteLine("|".PadRight(spazio) + sotto_titolo + "|".PadLeft(spazio));
                disegnariga();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }        
        }

        private static void disegnariga()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("-");
            Console.WriteLine("");
        }
    }
}
