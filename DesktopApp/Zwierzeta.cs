using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopApp;

    class Zwierzeta
    {
        public string Nazwa { get; set; }
        public string Opis { get; set; }

        public Zwierzeta(string nazwa, string opis)
        {
            Nazwa = nazwa;
            Opis = opis;
        }
    

    public static void WyswietlZwierzeta()
        {

        // Tablica zawierająca obiekty Zwierze
        Zwierzeta[] zwierzeta = new Zwierzeta[]
        {
            new Zwierzeta("Kot", "Małe, futrzaste zwierzę, lubiące drzemki i polowania."),
            new Zwierzeta("Pies", "Wierny przyjaciel człowieka, oddany i pełen energii."),
            new Zwierzeta(" Ryś", "dziki kot, zamieszkujący lasy górskie, znany ze swojej zwinności i elegancji"),
           new Zwierzeta(" Kameleon", "Egzotyczna jaszczurka zdolna zmieniać kolor skóry, aby dostosować się do otoczenia i uniknąć drapieżników."),
           new Zwierzeta(" Pingwin", "Kształtne ptaki morskie, niezdolne do latania, ale zręczne w pływaniu i zdolne do przetrwania w trudnych warunkach Antarktyki."),
           new Zwierzeta(" Koala", "Urocze stworzenia z Australii, spędzające większość czasu na drzewach, znane z ich słodkiego wyglądu i leniwego stylu życia."),
           new Zwierzeta(" Delfin", "Inteligentne morskie ssaki, znane ze swojej gracji i zdolności do interakcji z ludźmi."),
           new Zwierzeta(" Orzeł", "Symbol wolności i siły, majestatyczny ptak o szerokim rozpiętości skrzydeł, zdolny do lotu na wielkie odległości."),
           new Zwierzeta(" Tygrys", "Król dżungli, elegancki i groźny, wyróżniający się złotym futrem i czarnymi paskami."),
           new Zwierzeta(" Słoń", "Majestatyczne stworzenie o potężnych kłach i delikatnym sercu, symbol mądrości i siły."),
           new Zwierzeta(" Ryś", "dziki kot, zamieszkujący lasy górskie, znany ze swojej zwinności i elegancji"),
           new Zwierzeta(" Ryś", "dziki kot, zamieszkujący lasy górskie, znany ze swojej zwinności i elegancji"),
           new Zwierzeta(" Ryś", "dziki kot, zamieszkujący lasy górskie, znany ze swojej zwinności i elegancji"),
           new Zwierzeta(" Żyrafa", "Majestatyczne zwierzę afrykańskiej sawanny, znane ze swojej długiej szyi i eleganckiego chodu."),
           new Zwierzeta(" Lew", "Król sawanny, silny i dumny, z imponującą grzywą i potężnym rykiem."),
           new Zwierzeta(" Sowa", " Nocny ptak drapieżny, symbol mądrości i tajemniczości, znany ze swojego cichego lotu i ostrych pazurów."),
           new Zwierzeta(" Krokodyl", "Potężne drapieżniki wodne, znane ze swoich ostro zębów i zręczności w łowieniu zdobyczy."),
           new Zwierzeta(" Żubr", "Symbol Polskiej przyrody, potężne stworzenie z grzywą na szyi, które wędruje po bujnych polach."),
           new Zwierzeta(" Jeż", "Małe kolczaste stworzenie, które ochroni się w obręczy kłów, znane z ich uroczego wyglądu i umiejętności przekopywania się przez ogród."),
           new Zwierzeta(" Papuga", "Kolorowe ptaki, znane ze swojej zdolności do naśladowania ludzkiego mowy i żywych barw ich piór"),
        };
        // Wypisuje dostępne zwierzęta na liście
        Console.WriteLine("Dostępne zwierzęta na liście:");
        for (int i = 0; i < zwierzeta.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {zwierzeta[i].Nazwa}");
        }

        // Pobranie wyboru użytkownika
        Console.Write("Wybierz zwierzę (1-20): ");
            int wybor = int.Parse(Console.ReadLine()) -1;  //Pobiera dane wprowadzone przez użytkownika i sprowadza je do typu int ( zmniejssza o 1 jeśli jest taka potrzeba .bo aczyna się od 0)
        
        // Sprawdzenie czy wybór mieści się w zakresie tablicy
        if (wybor >= 0 && wybor < zwierzeta.Length)
        {
            // Wyświetla nazwę i opis wybranego zwierzęcia
            Console.WriteLine($"Nazwa: {zwierzeta[wybor].Nazwa}");
            Console.WriteLine($"Opis: {zwierzeta[wybor].Opis}");
        }
        else
        {
            Console.WriteLine("Błędny numer zwierzęcia!");
        }
        

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

