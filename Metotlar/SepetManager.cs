using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
       //  convention isimlendirme 
        //syntax yazım şekli 
        public void Ekle(Urun urun) //neyi eklemek istediğini parantez içerisinde tanımlaman lazım buna parametre deniyor  Urun tipi urun isimlendirmemiz
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string UrunAdi, string aciklama, double fiyat, int stokAdeti) // üçünü birden eklemeyi yapabilirsin ama yazma burada herhangi bir değişiklik yaptığında bütün sayfalar patlıyor 
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + UrunAdi);
        }

    }
}
