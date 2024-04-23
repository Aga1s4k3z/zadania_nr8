using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    public class Tablice
    {
        
        public void Powitanie() {
            Console.WriteLine("Witaj w klasie Tablice :)");
        }
        public int[] Stworz_tab()
        {
            //pytanie o długość tablicy
            Console.Write("Podaj długości ma być tablica? :) ");
            int dl = int.Parse(Console.ReadLine());
            //stworzyć tablicę o danej długości
            int[] tab = new int[dl];
            //zapełnić tablicę liczbami podanymi przez użytkownika
            Console.WriteLine("Podaj liczby: ");
            for ( int i = 0; i < tab.Length; i++ )
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return tab;
        }

    }
}
