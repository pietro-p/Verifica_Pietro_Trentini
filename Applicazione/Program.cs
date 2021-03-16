using System;
using TariffeLibrary;

namespace Applicazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci i giorni che vuoi andare in palestra");
            int giorni = int.Parse(Console.ReadLine());
            String tariffa = Gestione.VisualizzaTariffa(giorni);
            Console.WriteLine($"L'abbonameno piu conveniente che è stato scelto per te è di {tariffa}");

        }
    }
}
