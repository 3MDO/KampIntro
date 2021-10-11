using System;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };



            Urun urun1  = new Urun(); //bu yaptığımız classın örneği oluyor - ürün tipinde urunadi tanımlıyorsun veya fiyat  class içerisinden bişey tanımlıyorsun kısaca 
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması ";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 }; //urun1,urun2 gibi veriler bir veri kaynağından gelir normalde bizim elle girdiğimiz gibi girilmez  

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi); //programcı yazdığını görmek için yazıyor 
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------");
            }

            Console.WriteLine("-----------Metotlar");
            //intance  -  Class örneği oluşturma 
            // enCapsulation 
            
            SepetManager sepetManager = new SepetManager(); // başka sayfadan çağırıyoruz 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma ", 13, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20, 3);


        }

    }
}
