using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaccia
{
    internal class Complesso
    {
        List<ISuonatore> lista= new List<ISuonatore>();

        public void AggiungiStrumento(Strumento str)
        {
            lista.Add(str);
        }

        public void AggiungiRumorista(Rumorista rum)
        {
            lista.Add(rum);
        }

        public void Play()
        {
            foreach (var item in lista)
            {
                item.Suona();
            }
        }
    }
}
