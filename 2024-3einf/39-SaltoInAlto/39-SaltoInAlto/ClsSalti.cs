using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_SaltoInAlto
{
    internal class ClsSalti
    {
        static Random rnd = new Random();
        internal static void CaricaNazioni(string[] nazione)
        {
            string[] stati = { "Italia", "Cossovo", "Jamaica", "Francia" };
            for (int i = 0; i < nazione.Length; i++)
            {
                int index = rnd.Next(stati.Length);
                nazione[i] = stati[index];
            }
        }

        internal static void CaricaSalti(int[] salti)
        {
            for (int i = 0;i < salti.Length; i++)
            {
                int misura = rnd.Next(190,240);
                salti[i] = misura;
            }
        }

        internal static void CaricaSesso(string[] sesso)
        {
            for(int i = 0; i<sesso.Length; i++)
            {
                int sex = rnd.Next(2);
                sesso[i] = sex == 0 ? "M" : "F";
            }
        }
    }
}
