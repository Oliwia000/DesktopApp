using System;
using System.Collections.Generic;

namespace DesktopApp
{
    public class Ciekawostki
    {
        private static List<string> ciekawostki = new List<string>();

        public static void WyswietlCiekawostki()
        {
            Console.WriteLine("Ciekawostki:");

            if (ciekawostki.Count == 0)
            {
                Console.WriteLine("Brak ciekawostek.");
            }
            else
            {
                Console.WriteLine("Lista ciekawostek:");

                foreach (var ciekawostka in ciekawostki)
                {
                    Console.WriteLine(ciekawostka);
                }
            }

            // Zapytanie użytkownika, czy chce dodać nową ciekawostkę
            Console.WriteLine("Czy chcesz dodać nową ciekawostkę? (tak/nie)");
            string odpowiedz = Console.ReadLine();

            if (odpowiedz.ToLower() == "tak")
            {
                // Po wyborze dodaaj ciekawostki
                Console.WriteLine("Dodaj nową ciekawostkę:");
                Console.WriteLine("Wpisz treść ciekawostki:");
                string nowaCiekawostka = Console.ReadLine();

                // Dodanie nowej ciekawostki do listy
                ciekawostki.Add(nowaCiekawostka);

                Console.WriteLine("Ciekawostka została dodana.");
            }
            // Wyświetla wszystkich ciekawostki
            Console.WriteLine("Wszystkie ciekawostki:");
            foreach (var ciekawostka in ciekawostki)
            {
                Console.WriteLine(ciekawostka);
            }
        }
    }
}


          

  


 