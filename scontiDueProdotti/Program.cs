using System;

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
            if(importo_primo_prodotto<importo_secondo_prodotto)
            {
                sconto = (importo_primo_prodotto / 100) * 50;
                importo_primo_prodotto = importo_primo_prodotto - sconto;
                importo_totale = importo_secondo_prodotto + importo_primo_prodotto;
                Console.WriteLine("Il costo dell'importo totale è: " + importo_totale);
            }else if (importo_primo_prodotto > importo_secondo_prodotto)
            {
                sconto = (importo_secondo_prodotto / 100) * 50;
                importo_secondo_prodotto = importo_secondo_prodotto - sconto;
                importo_totale = importo_secondo_prodotto + importo_primo_prodotto;
                Console.WriteLine("L'importo totale è: " + importo_totale);
            }Console.ReadLine();
        }
    }
}
