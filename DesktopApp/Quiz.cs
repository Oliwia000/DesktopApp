﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public class Quiz
    {
        public static void RozpocznijQuiz()
        {

            Console.WriteLine("Quiz o zwierzętach:");
            {
                bool repeat = true;
                int highestscore = 0;
                while (repeat)
                {
                    Console.Clear();
                    Console.WriteLine($"Obecny najwyższy wynik: {highestscore}");
                    Console.WriteLine("Wybierz daną opcje i wciśnij enter");
                    Console.WriteLine("1. Rozpocznij quiz");
                    Console.WriteLine("2. Wyjd");
                    Console.WriteLine("Twój wybór:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            List<Question> questions = new List<Question>();
                            StreamReader file = new StreamReader(@"C:\Users\student\Source\Repos\DesktopApp\DesktopApp\odp.txt");
                            file.ReadLine();  //pomija od.kol.lin z pli.
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


        }
    }
}


            
             
    

