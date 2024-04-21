using System;

namespace DesktopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool zakonczono = false;

            while (!zakonczono)
            {
                Console.WriteLine("Witaj na stronie głównej!");

                // Tworzenie menu
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Zwierzęta");
                Console.WriteLine("2. Quiz o zwierzętach");
                Console.WriteLine("2. Ciekawostki");
                Console.WriteLine("3. Forum");
                Console.WriteLine("4. Zamknij program");

                // Pobranie wyboru użytkownika
                Console.Write("Wybierz opcję: ");
                int wybor = int.Parse(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Zwierzeta.WyswietlZwierzeta();
                        break;
                    case 2:
                        RozpocznijQuiz();
                        break;
                    case 3:
                        Ciekawostki.WyswietlCiekawostki();
                        break;
                    case 4:
                        Forum forum = new Forum();
                        forum.WyswietlPytania();
                        break;
                    case 5:
                        zakonczono = true;
                        break;
                    default:
                        Console.WriteLine("Błędny wybór opcji!");
                        break;
                }
            }
        }
        static void RozpocznijQuiz()
        {
            
            Console.WriteLine("Quiz o zwierzętach:");
            Console.WriteLine("1. Pytanie 1: ...");
            Console.WriteLine("2. Pytanie 2: ...");
            Console.WriteLine("3. Pytanie 3: ...");
            
        }



    }
}

            
             