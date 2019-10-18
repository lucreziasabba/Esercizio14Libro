using System;
using controllo;

namespace scontiDueProdotti
{
    class Program
    {
        static void Main(string[] args)
        {
            double importo_primo_prodotto = 0;
            double importo_secondo_prodotto = 0;
            double importo_totale = 0;
            double sconto = 0;
            Console.WriteLine("Inserisci l'importo del primo prodotto: ");
            importo_primo_prodotto = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'importo del secondo prodotto: ");
            importo_secondo_prodotto = double.Parse(Console.ReadLine());
            importo_totale = Sconto.CalcolaSconto(importo_primo_prodotto, importo_secondo_prodotto);
            Console.WriteLine($"{importo_totale}");
            Console.ReadLine();
        }
    }
}
