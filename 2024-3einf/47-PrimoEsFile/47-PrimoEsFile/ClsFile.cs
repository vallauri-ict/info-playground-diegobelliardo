using System;
using System.IO;

namespace _47_PrimoEsFile
{
    public class ClsFile
    {
        public static string[] LeggiParoleNonRipetute(string inputFile)
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
                    pos = CercaParolaNonDuplicata(parole[j], paroleDistinte, posDiPartenza);
                    if (pos == -1) // pos è -1 se non ho trovato la parola
                    {
                        paroleDistinte[i] = parole[j];
                        i++;
                    }
                }
            }
            sr.Close();
            return paroleDistinte;
        }

        public static string LeggiTutto(string inputFile)
        {
            return File.ReadAllText(inputFile);
        }

        public static void ModificaFile(string outputFile, string content)
        {
            File.WriteAllText(outputFile, content);
        }

        public static void ContaLineeParole(string inputFile, ref int nLinee, ref int nParole)
        {
            StreamReader sr = new StreamReader(inputFile);
            string riga = "";
            while (!sr.EndOfStream)
            {
                riga = sr.ReadLine();
                nLinee++;
                // string[] parole = riga.Split(' ');
                // nParole += parole.Length;
                nParole += riga.Split(' ').Length;
            }
        }

        private static int CercaParolaNonDuplicata(string parola, string[] paroleDistinte, int posDiPartenza)
        {
            int retVal = -1;
            int i = 0;
            while (paroleDistinte[i] != null && i < paroleDistinte.Length)
            {
                if (paroleDistinte[i] == parola)
                    return i;
                i++;
            }
            return retVal;
        }

        public static int ContaOccorrenze(string inputFile, string parola)
        {
            int retVal = 0;

            StreamReader sr = new StreamReader(inputFile);
            while (!sr.EndOfStream)
            {
                string riga = sr.ReadLine();
                string[] parole = riga.Split(' ');
                for (int j = 0; j < parole.Length; j++)
                {
                    if (parole[j] == parola)
                        retVal++;
                }
            }
            sr.Close();

            return retVal;
        }
    }
}