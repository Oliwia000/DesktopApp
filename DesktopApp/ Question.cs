namespace DesktopApp

    class Question //Definicja klasy
{
    public int id { get; set; }   // przechowuje id pytania
    public string pytanie { get; set; }
    public int poprawnaOdpowiedz { get; set; }
    public string Odpowiedz1 { get; set; }
    public string Odpowiedz2 { get; set; }
    public string Odpowiedz3 { get; set; }
    public string Odpowiedz4 { get; set; }

    //Konstruktor klasy
    public Question(int id, string pytanie, int poprawnaOdpowiedz, string Odpowiedz1, string Odpowiedz2, string Odpowiedz3, string Odpowiedz4)
    {
        this.id = id;
        this.pytanie = pytanie;
        this.poprawnaOdpowiedz = poprawnaOdpowiedz;
        this.Odpowiedz1 = Odpowiedz1;
        this.Odpowiedz2 = Odpowiedz2;
        this.Odpowiedz3 = Odpowiedz3;
        this.Odpowiedz4 = Odpowiedz4;
    }
}