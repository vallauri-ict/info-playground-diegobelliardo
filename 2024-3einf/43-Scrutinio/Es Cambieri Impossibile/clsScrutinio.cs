using System;

namespace Es_Cambieri_Impossibile
{
    public class clsScrutinio
    {
        static Random rnd = new Random();
        public static string[] studenti = { "Ambrogio", "Bodoaga", "Burdisso", "Cerone",
        "Dzeglio","Ferrero","Fontana","Hoxa","Kardash","Lamberti"
        ,"Marino","Minetti","Mondino","Mossello","Negro","Olivero","Parola","Pasquero","Peano"
        ,"Poputoaia","Rozzani","Singh","Tesio"};

        public static string[] materie = { "ITALIANO","STORIA","INGLESE","MATEMATICA","INFORMATICA","SISTEMI","TPSIT","TELECOMUNICAZIONI"};

        public static int[,] voti=new int[studenti.Length,materie.Length];
        public static void CaricaVoti()
        {
            for (int i = 0; i < studenti.Length; i++) { 
                for (int j = 0; j < materie.Length; j++){
                    voti[i,j] = rnd.Next(4,11);
                }
            }
        }
    }
}
