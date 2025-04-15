using System;
using System.IO;

namespace _47_PrimoEsFile
{
    internal class ClsFile
    {
        internal static string[] LeggiParoleNonRipetute(string inputFile)
        {
            StreamReader sr = new StreamReader(inputFile);
            string riga = "";
            string[] parole;
            string[] paroleDistinte = new string[100];
            int pos,i=0,posDiPartenza;

            while (!sr.EndOfStream)
            {
                riga = sr.ReadLine();
                parole = riga.Split(' ');
                posDiPartenza = 0;
                for (int j = 0; j < parole.Length; j++)
                {
                    pos = CercaParolaNonDuplicata(parole, paroleDistinte, posDiPartenza);
                    if (pos != -1)
                    {
                        paroleDistinte[i] = parole[pos];
                        i++;
                    }
                }
            }
            //Resize ???
            return paroleDistinte;
        }

        private static int CercaParolaNonDuplicata(string[] parole, string[] paroleDistinte, int posDiPartenza)
        {
            int retVal = -1;



            return retVal;
        }
    }
}