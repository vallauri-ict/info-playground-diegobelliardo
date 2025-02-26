using System;

namespace Es_Cambieri_Impossibile
{
    public class ClsScrutinio
    {
        static Random rnd = new Random();
        public static string[] studenti = { "Ambrogio", "Bodoaga", "Burdisso", "Cerone",
        "Dzeglio","Ferrero","Fontana","Hoxa","Kardash","Lamberti"
        ,"Marino","Minetti","Mondino","Mossello","Negro","Olivero","Parola","Pasquero","Peano"
        ,"Poputoaia","Rozzani","Singh","Tesio"};

        public static string[] materie = { "ITALIANO","STORIA","INGLESE","MATEMATICA","INFORMATICA","SISTEMI","TPSIT","TELECOMUNICAZIONI"};

        public static int[,] voti=new int[studenti.Length,materie.Length];
        public static void CaricaVoti(int min,int max)
        {
            for (int i = 0; i < studenti.Length; i++) { 
                for (int j = 0; j < materie.Length; j++){
                    voti[i,j] = rnd.Next(min,max);
                }
            }
        }

        internal static void contaEsiti(ref int nPromossi, ref int nBocciati, ref int nRimandati)
        {
            int contaInsufficienze = 0;

            for (int i = 0;i < voti.GetLength(0);i++)
            {
                contaInsufficienze = 0;
                for(int j = 0;j < voti.GetLength(1); j++)
                {
                    if(voti[i,j] < 6)
                    {
                        contaInsufficienze++;
                    }
                }
                if (contaInsufficienze == 0)
                {
                    nPromossi++;
                }
                else if (contaInsufficienze > 3)
                {
                    nBocciati++;
                }
                else nRimandati++;
            }
        }
    }
}
