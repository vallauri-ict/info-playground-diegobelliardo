using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Uguaglianza
{
    class Persona
    {
        public string Nome { get; }
        public string Cognome { get; }

        public Persona(string nome,string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public override bool Equals(object obj)
        {
            if ((obj != null) && ((obj as Persona).Nome==this.Nome) && ((obj as Persona).Cognome == this.Cognome))
            {
                return true;
            }
            else return false;
        }

        public static bool operator ==(Persona left, Persona right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Persona left, Persona right)
        {
            return !Equals(left, right);
        }

        public override int GetHashCode()
        {
            string s = Cognome + Nome;
            return s.GetHashCode();
        }
    }
}
