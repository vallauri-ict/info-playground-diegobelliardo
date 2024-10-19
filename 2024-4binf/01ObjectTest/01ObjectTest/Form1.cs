using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01ObjectTest
{
    public partial class btnGeneraFattura : Form
    {
        List<Fattura> fatturaList=new List<Fattura>();
        public btnGeneraFattura()
        {
            InitializeComponent();
            Padre p = new Padre();
            p.Eta = 10;
            Console.WriteLine(p.Eta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fattura f = new Fattura();
            fatturaList.Add(f);
            MessageBox.
          Show("Generata fattura n.: "+f.NFattura);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s="";
            foreach (var f in fatturaList)
            {
                s += "Numero Fattura: " + f.NFattura + "\n";
            }
            MessageBox.Show(s);
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            Singleton a = Singleton.getInstance();
            a.Val= 10;
            MessageBox.Show("Val di a: "+a.Val);
            Singleton b = Singleton.getInstance();
            b.Val= 20;
            MessageBox.Show($"Val di a: {a.Val}\nVal di b: {b.Val}");
            Singleton c = Singleton.getInstance();
            c.Val= 30;
            MessageBox.Show($"Val di a: {a.Val}\nVal di b: {b.Val}\nVal di c: {c.Val}");
        }

        private void btnIndexed_Click(object sender, EventArgs e)
        {
            Indexed i= new Indexed(5);
            string s = "";
            for (int j = 0; j < 5; j++)
            {
                s += $"indexed[{j}]= {i[j]}\n";
            }
            MessageBox.Show(s);
            i.ordinaElementi();
            s = "";
            for (int j = 0; j < 5; j++)
            {
                s += $"indexed[{j}]= {i[j]}\n";
            }
            MessageBox.Show(s);
        }
    }
}
