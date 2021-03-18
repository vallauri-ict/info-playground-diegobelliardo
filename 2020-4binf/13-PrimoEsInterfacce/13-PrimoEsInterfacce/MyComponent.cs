using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_PrimoEsInterfacce
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id=0;
        private bool _status;

        public int id { get => _id; set => _id=value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            id++;
            MessageBox.Show("Connesso a: "+s);

        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Disconnesso da: "+s);
        }

        public void Stato()
        {
            if (status)
            {
                MessageBox.Show("Attualmente Connesso con id: " + id);
            }
            else
                MessageBox.Show("Non Connesso!");
        }
    }
}
