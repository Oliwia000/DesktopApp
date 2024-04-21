using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DesktopApp
{
    // Interfejs dla forum z pytaniami
    public interface IForum
    {
        void DodajPytanie(string pytanie);
        void UsunPytanie(string pytanie);
        void EdytujPytanie(string pytanie, string nowePytanie);
        void WyswietlPytania();
    }

    // Klasa reprezentująca forum z pytaniami
    public class Forum : IForum
    {
        // Ścieżka do pliku XML
        private string sciezkaPliku = "forum.xml";

        // Lista pytań na forum
        private List<string> pytania = new List<string>();

        public Forum()
        {
            // Wczytanie pytań z pliku XML przy tworzeniu instancji klasy
            WczytajZPliku();
        }

        // Dodawanie pytania do forum
        public void DodajPytanie(string pytanie)
        {
            pytania.Add(pytanie);
            ZapiszDoPliku();
        }

        // Usuwaniie pytania z forum
        public void UsunPytanie(string pytanie)
        {
            pytania.Remove(pytanie);
            ZapiszDoPliku();
        }

        // Edytowanie pytania na forum
        public void EdytujPytanie(string pytanie, string nowePytanie)
        {
            int index = pytania.IndexOf(pytanie);
            if (index != -1)
            {
                pytania[index] = nowePytanie;
                ZapiszDoPliku();
            }
        }

        // Wyświetlenie pytań na forum
        public void WyswietlPytania()
        {
            Console.WriteLine("Pytania na forum:");

            if (pytania.Count == 0)
            {
                Console.WriteLine("Brak pytań na forum.");
            }
            else
            {
                foreach (var pytanie in pytania)
                {
                    Console.WriteLine($"- {pytanie}");
                }
            }
        }

        // Zapisuje pytania do pliku XML
        private void ZapiszDoPliku()
        {
            using (var writer = new XmlTextWriter(sciezkaPliku, null))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                serializer.Serialize(writer, pytania);
            }
        }

        // Wczytywanie pytań z pliku XML
        private void WczytajZPliku()
        {
            if (File.Exists(sciezkaPliku))
            {
                using (var reader = new XmlTextReader(sciezkaPliku))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                    pytania = (List<string>)serializer.Deserialize(reader);
                }
            }
        }
    }
}
