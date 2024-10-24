using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElementoBiblioteca generico=new ElementoBiblioteca();
            Libro libro=new Libro();
            Rivista rivista=new Rivista();
            DVD dvd = new DVD();

            generico.Autore = "Tesla";
            generico.Titolo = "Quaderno appunti";
            generico.AnnoPubblicazione = 1901;

            libro.Genere = "Giallo";
            libro.Autore = "Agata";
            libro.Titolo = "La signora in giallo";
            libro.AnnoPubblicazione = 1997;

            rivista.Autore = "Franca";
            rivista.Titolo = "Vogue";
            rivista.NumeroEdizione = 103;
            rivista.AnnoPubblicazione = 2014;

            dvd.Autore = "Disney";
            dvd.Titolo = "Il re leone";
            dvd.AnnoPubblicazione = 2005;
            dvd.Regista = "Nincof";

            Console.WriteLine($"Il libro {libro.Titolo} è un genere " +
                $"{libro.Genere} può essere prelevato per {libro.CalcolaPrestito()}");
            Console.WriteLine($"La rivista {rivista.Titolo} è il numero " +
                $"Edizione {rivista.NumeroEdizione} può essere prelevato per {rivista.CalcolaPrestito()}");
            Console.WriteLine($"Il DVD {dvd.Titolo} è del regista " +
                $"{dvd.Regista} può essere prelevato per {dvd.CalcolaPrestito()}");
            Console.WriteLine($"Il generico {generico.Titolo} può essere " +
                $"prelevato per: {generico.CalcolaPrestito()}");
            
            Console.ReadKey();
        }
    }
}
