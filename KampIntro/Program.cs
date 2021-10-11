using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // alliance takma isim kategori etiketi 
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu ");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu ");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu ");
            }


            if (sistemeGirisYapmisMi ==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu ");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu ");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}