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
        public void Wyswietl_tab(int[] tab)
        {
            
            for ( int i = 0;i < tab.Length;i++ )
            {
                Console.Write(tab[i]+", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public int[] Sort(int[] tab)
        {
            for ( int i = 0; i < tab.Length ; i++ ) {
            for ( int j = 0; j < tab.Length - 1 ; j++ )
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
            return tab;
        } 
        public bool Przeszukiwanie(int[] ints, int sz)
        {
            bool tak = false;
            for (int i=0;i<ints.Length;i++) {
            if (ints[i] == sz)
                {
                    tak = true;
                    return true;
                }
            }
            if (tak == false) { return false; } else { return false; }
        }
    }
}
