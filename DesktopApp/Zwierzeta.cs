using System;
using System.Collections.Generic;

namespace DesktopApp
{
    class Zwierzeta
    {
        //public static void WyswietlZwierzeta()
      //  {
          //  Console.WriteLine("Lista zwierząt:");
           // List<string> zwierzeta = new List<string> { "Lew", "Słoń", "Żyrafa", "Tygrys", "Panda", "Krokodyl", "Orzeł", "Wąż", "Kot", "Pies" };

          //  foreach (var zwierze in zwierzeta)
            //{
           //     Console.WriteLine(zwierze);
          //  }

           // Console.Write("Wybierz zwierzę: ");
           // string wybraneZwierze = Console.ReadLine();

            // Wyświetlenie opisu i zdjęcia wybranego zwierzęcia
          //  Console.WriteLine($"Opis zwierzęcia {wybraneZwierze}:");
            // Tutaj można dodać kod do wyświetlenia opisu i zdjęcia wybranego zwierzęcia
      //  }
   // }
//}
 public static void WyswietlZwierzeta()
{
    // Wypisz 20 nazw zwierząt
    Console.WriteLine("Zwierzęta:");
    for (int i = 1; i <= 20; i++)
    {
        Console.WriteLine($"{i}. Zwierzę {i}");
    }

    // Pobranie wyboru użytkownika
    Console.Write("Wybierz zwierzę (1-20): ");
    int wybor = int.Parse(Console.ReadLine());

    // Wyświetla opis wybranego zwierzęcia
    Console.WriteLine($"Opis zwierzęcia {wybor}: Lorem ipsum dolor sit amet, consectetur adipiscing elit.");

    // Wyświetlenie menu
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Powrót do menu głównego");
    Console.WriteLine("2. Zamknij program");
    Console.Write("Wybierz opcję: ");
    int menuWybor = int.Parse(Console.ReadLine());

    switch (menuWybor)
    {
        case 1:
            // Powrót do menu głównego
            break;
        case 2:
            Environment.Exit(0); // Zamknięcie programu
            break;
        default:
            Console.WriteLine("Błędny wybór opcji!");
            break;
    }
}
    }
}