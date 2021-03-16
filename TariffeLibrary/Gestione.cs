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
                costo = "115.99 al mese";

            }
            else if (giorni >= 32 && giorni <= 90)
            {
                costo = "99.99 al mese";

            }
            else if (giorni >= 91 && giorni <= 365)
            {
                costo = "79.99 al mese";
            }
            return costo;
        }
    }
}