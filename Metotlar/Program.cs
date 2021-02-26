using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();            
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe--tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("---------------Metotlar-------------");

            //instance -- örnek
            //encapsulation -- 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.EkleAlternatif("Armut", "Yeşi armut", 12, 10);
            sepetManager.EkleAlternatif("Elma", "Yeşi elma", 12, 9);
            sepetManager.EkleAlternatif("Karpuz", "Diyarbakır karpuzu", 12, 8);



        }
    }
}


//Dont repeat yourself(Kendini tekrar etme) - DRY - Clean Code(Temiz kod) - Best Practice