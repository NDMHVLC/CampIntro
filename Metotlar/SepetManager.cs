using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention -- isimlendirme kuralı
        //syntax -- yazım değişimleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

            
        }

       

        //önerilmeyen class
        public void EkleAlternatif(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("----------------------------");

            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }

    }
}
