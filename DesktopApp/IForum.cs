namespace DesktopApp
{
    public interface IForum
    {
        void DodajPytanie(string pytanie);
        void UsunPytanie(string pytanie);
        void EdytujPytanie(string pytanie, string nowePytanie);
        void WyswietlPytania();
    }
}