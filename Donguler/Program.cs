using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] 
            {"Yazılım geliştirici yetiştirme kampı","Programlamaya bşalangıç için temel kurs", "Java", "Python", "C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                
            }

            Console.WriteLine("-For bitimi-");
            foreach  (string kurs in kurslar) //foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
