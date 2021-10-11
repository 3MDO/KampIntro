using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs ";
            string kurs3 = "Java";
            string kurs4 = "Phyton";


            string[] kurslar = new string[] { "Yazılım geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs ", "Java","Phyton" };

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
