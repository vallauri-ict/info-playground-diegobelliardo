using System;
using System.Collections.Generic;

namespace IComparer
{
    internal class Persona
    {
        public string nome;
        public string citta;

        public Persona(string nome, string citta)
        {
            this.nome = nome;
            this.citta = citta;
        }

        public override string ToString()
        {
            return $"{nome} - {citta}";
        }

        public static confrontaCitta cmpCitta()
        {
            return new confrontaCitta();
        }

        public static confrontaNome cmpNome()
        {
            return new confrontaNome();
        }

        public class confrontaNome : IComparer<Object>
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 == null && obj2 == null) return 0;
                else if (obj1 == null) return 1;
                else if (obj2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)obj1;
                    Persona p2 = (Persona)obj2;
                    return String.Compare(p1.nome, p2.nome, true);
                }
            }
        }

        public class confrontaCitta : IComparer<Object>
        {
            public int Compare(object obj1, object obj2)
            {
                if (obj1 == null && obj2 == null) return 0;
                else if (obj1 == null) return 1;
                else if (obj2 == null) return -1;
                else
                {
                    Persona p1 = (Persona)obj1;
                    Persona p2 = (Persona)obj2;
                    return String.Compare(p1.citta, p2.citta, true);
                }
            }
        }

    }
}
