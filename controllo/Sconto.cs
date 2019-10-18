using System;

namespace controllo
{
    public class Sconto
    {
        public static double CalcolaSconto(double importo_primo_prodotto, double importo_secondo_prodotto)
        {
            double importo_totale=0;
            if (importo_primo_prodotto < importo_secondo_prodotto)
            {
                double sconto = (importo_primo_prodotto / 100) * 50;
                importo_primo_prodotto = importo_primo_prodotto - sconto;
                importo_totale = importo_secondo_prodotto + importo_primo_prodotto;
               
            }
            else if (importo_primo_prodotto > importo_secondo_prodotto)
            {
                double sconto = (importo_secondo_prodotto / 100) * 50;
                importo_secondo_prodotto = importo_secondo_prodotto - sconto;
                importo_totale = importo_secondo_prodotto + importo_primo_prodotto;
        
            }
            return importo_totale;
        }
    }
}
