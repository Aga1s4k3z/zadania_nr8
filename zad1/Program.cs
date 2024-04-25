using zad1;

class Program
{
    static void Main(string[] args)
    {

        //wywołujemy obiekt 'Tablice'
        Tablice t = new Tablice();
        t.Powitanie();
        int[] ints = t.Stworz_tab();
        Console.Clear();
        Console.WriteLine("Elementy tablicy:");
        t.Wyswietl_tab(ints);
        Console.WriteLine("Posortowana tablica: ");
        int[] tab = t.Sort(ints);
        t.Wyswietl_tab(tab);
        Console.Write("Jakiej liczby szukasz? ");
        int sz = int.Parse(Console.ReadLine());
        Console.WriteLine(t.Przeszukiwanie(tab, sz));
    }
}