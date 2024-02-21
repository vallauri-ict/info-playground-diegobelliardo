using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_EsInterfacciaLibri
{
    internal class BookStore
    {
        private List<IBook> books;

        public BookStore()
        {
            books = new List<IBook>();
        }

        public void SellBook(IBook book)
        {
            books.Add(book);
            MessageBox.Show($"Libro venduto: {book.Titolo} di {book.Autore} al prezzo di {book.Prezzo}€");
        }

        public double CalculateTotalSales()
        {
            double totalSales = 0;
            foreach (var book in books)
            {
                totalSales += book.Prezzo;
            }

            return totalSales;
        }

        public void DisplayBooksSold()
        {
            string msg = "Libri venduti:\n";
            foreach (var book in books)
            {   
                msg += $"{book.Titolo} di {book.Autore} - Prezzo: {book.Prezzo}€\n";
            }
            MessageBox.Show(msg);
        }
    }
}
