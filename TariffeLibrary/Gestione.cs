using System;

namespace TariffeLibrary
{
    public class Gestione
    {
        public static string VisualizzaTariffa(int giorni)
        {
            string costo = "";
            if (giorni >= 1 && giorni <= 31)
            {
                costo = "Un mese a 115.99";

            }
            else if (giorni >= 32 && giorni <= 90)
            {
                costo = "Tre mesi 99.99 al mese";

            }
            else if (giorni >= 91 && giorni <= 365)
            {
                costo = "Dodici mesi 79.99 al mese";
            }
            return costo;
        }
    }
}