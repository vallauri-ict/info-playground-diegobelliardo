using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confronto_ordinamenti
{
    public class clsvettori
    {
        static Random rand = new Random();
        public static void Caricavetdisordinato(int[] vet,bool semi, int n, bool ordinato)
        {
            if (semi)
            {
               
                for (int i = 0; i < vet.Length; i++)
                {
                    if (i % 10 == 0 && i!=0)
                    {
                        vet[i-1] = rand.Next(1, 100000);
                    }
                    else
                    {
                        vet[i] = i;
                    }
                    
                }
            }
            else
            {
                if (ordinato)
                {

                    for (int i = 0; i < vet.Length; i++)
                    {
                        vet[i] = i;
                    }
                }
                else
                {
                    for(int i = 0;i < vet.Length; i++)
                    {
                        vet[i] = rand.Next(1, 100000);
                    }
                }
            }

        }
        
        public static void OrdinaPerSelezione(int[] vet, ref long Passi, ref long Confronti, ref long Scambi)
        {
            int posMin;
            int aus;

            for (int i = 0; i < vet.Length - 1; i++)
            {
                Passi++;
                posMin = i;
                for (int j = i + 1; j < vet.Length; j++)
                {
                    Confronti++;
                    if (vet[j] < vet[posMin])
                        posMin = j;
                }
                if (posMin != i)
                {
                    Scambi++;
                    aus = vet[i];
                    vet[i] = vet[posMin];
                    vet[posMin] = aus;
                }
            }

        }

        public static void OrdinaPerScambio(int[] vet, ref long Passi, ref long Confronti, ref long Scambi)
        {
            int i = -1;
            bool scambio;
            int aus;

            do
            {
                Passi++;
                i++;
                scambio = false;

                for (int j = vet.Length - 2; j >= i; j--)
                {
                    Confronti++;

                    if (vet[j + 1] < vet[j])
                    {
                        Scambi++;
                        aus = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = aus;
                        scambio = true;
                    }
                }

            } while (i < vet.Length - 2 && scambio);
        }

        internal static void OrdinaPerScambioSpeciale(int[] vet, ref long Passi, ref long Confronti, ref long Scambi, int n)
        {
            bool primo = true;
            int i = -1;
            bool scambio;
            int aus;
            int min = 0;
            int max = vet.Length - 2;

            do
            {
                if (primo)
                {
                    Passi++;
                    i++;
                    scambio = false;

                    for (int j = max; j >= min; j--)
                    {
                        Confronti++;

                        if (vet[j + 1] < vet[j])
                        {
                            Scambi++;
                            aus = vet[j];
                            vet[j] = vet[j + 1];
                            vet[j + 1] = aus;
                            scambio = true;
                        }
                    }
                    primo= false;
                    min++;
                }
                else
                {
                    Passi++;
                    i++;
                    scambio = false;
                    
                    for (int j = min; j <= max; j++)
                    {
                        Confronti++;

                        if (vet[j + 1] < vet[j])
                        {
                            Scambi++;
                            aus = vet[j];
                            vet[j] = vet[j + 1];
                            vet[j + 1] = aus;
                            scambio = true;
                        }
                    }
                    primo = true;
                    max--;
                }

            } while (min<=max && scambio);
        }
    }
    
}
