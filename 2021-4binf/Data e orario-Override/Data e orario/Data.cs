using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class Data
    {
        private int giorno;
        private int mese;
        private int anno;
        int[] giorniMese = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] giorni = new string[] { "Lunedì","Martedì","Mercoledì","Giovedì","Venerdì","Sabato","Domenica" };
        public Data(int giorno, int mese, int anno)
        {
            this.anno = anno;
            this.giorno = giorno;
            this.mese = mese;
        }
        public Data()
        {
            this.anno = 1900;
            this.mese = 1;
            this.giorno = 1;
        }

        public override string ToString()
        {
            return giorno+"/"+mese+"/"+anno;
        }
        public virtual bool bisestile()
        {
            return DateTime.IsLeapYear(anno);
            /*
            if (anno % 4 == 0)
                return true;
            else
                return false;*/
        }
        public virtual void leggi(int giorno, int mese, int anno)
        {
            this.giorno = giorno;
            this.mese = mese;
            this.anno = anno;
        }
        public virtual void scrivi(ref int giorno, ref int mese, ref int anno)
        {
            giorno = this.giorno;
            mese = this.mese;
            anno = this.anno;
        }
        public virtual void Domani()
        {
            DateTime dt = new DateTime(anno, mese , giorno);

            dt.AddDays(1);
            anno = dt.Year;
            mese = dt.Month;
            giorno = dt.Day;
           
            /*
            if (bisestile())
                giorniMese[1] = 29;
            else
                giorniMese[1] = 28;
            if (giorno < giorniMese[mese - 1])
            {
                giorno++;
            }
            else
            {
                giorno = 0;
                if (mese < 12)
                    mese++; 
                else
                {
                    mese = 0;
                    anno++;
                }
            }*/
        }


        public virtual void Ieri()
        {
            DateTime dt = new DateTime(anno, mese, giorno);

            dt.AddDays(-1);
            anno = dt.Year;
            mese = dt.Month;
            giorno = dt.Day;

            /*
            if (bisestile())
                giorniMese[1] = 29;
            else
                giorniMese[1] = 28;
            if (giorno > 0)
            {
                giorno--;
            }
            else
            {
                giorno = giorniMese[mese-1];
                if (mese >0)
                    mese--;
                else
                {
                    mese = 12;
                    anno--;
                }
            }*/
        }



        public virtual string Giorno()
        {
            DateTime dt = new DateTime(anno, mese, giorno);


            return dt.DayOfWeek.ToString();

            // return giorni[(giorno-1) % 7 ];
        }
    }

}
