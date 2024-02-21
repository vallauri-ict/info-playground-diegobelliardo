using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_EsInterfacciaLibri
{
    public partial class Form1 : Form
    {
        BookStore bookStore= new BookStore();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVenduto_Click(object sender, EventArgs e)
        {
            IBook book = new Book(txtTitolo.Text, txtAutore.Text, 
                                    Convert.ToDouble(txtPrezzo.Text));
            bookStore.SellBook(book);
        }

        private void btnTotaleVendite_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sono stati venduti per {bookStore.CalculateTotalSales()}€ di libri"); ;
        }

        private void btnLibriVenduti_Click(object sender, EventArgs e)
        {
            bookStore.DisplayBooksSold();
        }
    }
}
