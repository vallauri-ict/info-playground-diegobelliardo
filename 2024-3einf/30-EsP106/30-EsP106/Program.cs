using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _30_EsP106
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            int i = -1;
            bool scambio;
            Random rnd = new Random();

            for (int k = 0; k < v.Length; k++)
            {
                v[k] = rnd.Next(50);
            }
            

            do
            {
                i++;
                scambio = false;


                for (int j = (v.Length - 2); j >= i; j--)
                {
                    Console.Clear();
                    Console.WriteLine("Passo "+i+"\n");
                    stampaVet(v);
                    Thread.Sleep(1500);
                    if (v[j] > v[j + 1])
                    {
                        int aus = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aus;

                        scambio = true;
                    }
                }
            } while (scambio==true && i<v.Length-2);

            Console.ReadKey();

        }
        private static void stampaVet(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().PadLeft(3));
            }
        }
    } 
    }
