using System;
using System.Collections.Generic;

namespace DesktopApp
{
    public class Ciekawostki
    {
        public static List<string> ciekawostki = new List<string>();  //Deklaruje  listę ciekawostek



        public static void WyswietlCiekawostki()
        {
            Console.WriteLine("Ciekawostki:");

            if (ciekawostki.Count == 0)  //Sprawdza, czy lista ciekawostek jest pusta
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
                string nowaCiekawostka = Console.ReadLine();  //pobiera nową ciekawostkę

                // Dodanie nowej ciekawostki do listy
                ciekawostki.Add(nowaCiekawostka);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Ciekawostka została dodana.");
            }
            // Wyświetla wszystkie ciekawostki
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Wszystkie ciekawostki:");
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (var ciekawostka in ciekawostki)
            {
                Console.WriteLine(ciekawostka);
            }
            // Wyświetlanie menu
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Wróć do menu głównego");
            Console.WriteLine("2. Zamknij program");

            // Pobieranie wyboru użytkownika
            Console.Write("Wybierz opcję: ");
            int wybor = int.Parse(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    Console.WriteLine("Powrót do menu głównego");
                    Console.ReadKey();
                    break;
                case 2:
                    Environment.Exit(0);   // Zamknij program
                    break;
                default:
                    Console.WriteLine("Błędny wybór opcji!");
                    break;
            }

         
        }
    }
}
