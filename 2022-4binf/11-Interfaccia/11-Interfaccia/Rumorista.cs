using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Interfaccia
{
    internal class Rumorista : Persona, ISuonatore
    {
        public string NomeDArte { get; set; }
        public void Suona()
        {
            System.Windows.Forms.MessageBox.Show("Emette suoni con la bocca");
        }
    }
}
