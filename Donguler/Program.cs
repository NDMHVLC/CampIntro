using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı", 
                "Proğramlama Başlangıç İçin Temel Kurs",
                "Java","Python","C++","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------for bitti-------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("--------------foreach bitti-----------------");

            Console.WriteLine("Sayfa sonu");

            




        }
    }
}
