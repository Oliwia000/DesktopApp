using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DesktopApp
{
    public interface IForum  // Interfejs dla forum z pytaniami
    {
        void DodajPytanie(string pytanie);
        void UsunPytanie(string pytanie);    //deklaracaja metody
        void EdytujPytanie(string pytanie, string nowePytanie);
        void WyswietlPytania();
    }
    public class Forum : IForum // Klasa reprezentująca forum z pytaniami
    {
        private string sciezkaPliku = "forum.xml";  // Ścieżka do pliku XML

        // Lista pytań na forum
        private List<string> pytania = new List<string>();

        public Forum()
        {
          WczytajZPliku(); // Wczytywanie pytań z pliku XML
        }
        public void DodajPytanie(string pytanie)  // Dodawanie pytania do forum
        {
            pytania.Add(pytanie);
            ZapiszDoPliku(); 
        }
        public void UsunPytanie(string pytanie)    // Usuwaniie pytania z forum
        {
            pytania.Remove(pytanie);
            ZapiszDoPliku();
        }

        // Edytowanie pytania na forum
        public void EdytujPytanie(string pytanie, string nowePytanie)
        {
            int index = pytania.IndexOf(pytanie);
            if (index != -1)    //Sprawdza czy pytanie zostało znalezione w liście
            {
                pytania[index] = nowePytanie;
                ZapiszDoPliku();
            }
        }

        // Wyświetla pytania na forum
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
        private void ZapiszDoPliku()    // Zapisuje pytania do pliku XML
        {
            using (var writer = new XmlTextWriter(sciezkaPliku, null))  //Tworzy obiekt writer do zapisu danych do pliku XML
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));  //Tworzy obiekt serializer do listy pytań
                serializer.Serialize(writer, pytania);
            }
        }
        // Wczytywanie pytań z pliku XML
        public void WczytajZPliku()
        {
            if (File.Exists(sciezkaPliku))
            {
                using (var reader = new XmlTextReader(sciezkaPliku)) //Tworzy o. reader do odczytu danych z pliku XML
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                    pytania = (List<string>)serializer.Deserialize(reader);   //odczytaniu wcześniej zapisane dane z pliku i przypisuje do listy pytań
                }
            }
        }
    }
}
