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
        
            static void Main(string[] args)
            {
                bool repeat = true;
                int highestscore = 0;
                while (repeat)
                {
                    Console.Clear();
                    Console.WriteLine($"Obecny najwyższy wynik: {highestscore}");
                    Console.WriteLine("Wybierz daną opcje i wciśnij enter");
                    Console.WriteLine("1. Rozpocznij quiz");
                    Console.WriteLine("2. Wyjdz");
                    Console.WriteLine("Twój wybór:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            List<Question> questions = new List<Question>();
                            StreamReader file = new StreamReader(@"C:\Users\Oliwia\Source\Repos\Oliwia000\DesktopApp\DesktopApp\odp.txt");
                            file.ReadLine();
                            while (!file.EndOfStream)  //Pętla wykonuje się dopóki nie osiągnie końca pliku
                            {
                                string[] words = file.ReadLine().Split(';');

                                Question newquestion = new Question(Convert.ToInt32(words[0]), words[1], Convert.ToInt32(words[2]), words[3], words[4], words[5], words[6]);
                                questions.Add(newquestion);
                            }
                            file.Close();
                            int maxpytan = 8;
                            int i = 0;
                            int punkty = 0;
                            while (i < maxpytan)
                            {
                    Console.Clear();
           Random randomQuestion = new Random();
            int q = randomQuestion.Next(questions.Count);
            Question question = questions[q];  //Wybiera losowe pytanie z listy
                                int odp = question.poprawnaOdpowiedz;
              Console.WriteLine(question.pytanie + ":");
              Console.WriteLine("1. " + question.Odpowiedz1);
              Console.WriteLine("2. " + question.Odpowiedz2);
              Console.WriteLine("3. " + question.Odpowiedz3);
              Console.WriteLine("4. " + question.Odpowiedz4);
                                int choice2 = Convert.ToInt32(Console.ReadLine());
                                if (choice2 == odp)    //// Sprawdza czy wybór użytkownika jest poprawny
                                {
                                    Console.WriteLine("Dobra Odpowiedz!");
                                    punkty++;
                                    i++;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine($"Zła odpowiedź, Poprawna odpowiedz to: {odp}");
                                    i++;
                                    Console.ReadKey();
                                }
                            }
                            if (highestscore < punkty)   //Sprawdza czy uzyskano nowy najlepszy wynik
                            {
                                highestscore = punkty;  //Aktualizuje najwyższy wynik
                            }
                            break;
                        case 2:
                            repeat = false;
                            break;
                    }
                }
            }
           // public static void LoadQuestions()
          //  public static void AddQuestions()  
          //  public static void gameEnd()
   
        }
    }
} 


            
             