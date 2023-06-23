using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // naming convetion = isimlendirme kuralı
        // syntax = yazım şekilleri
        public void Ekle (Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklamasi, double Fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
            
    }
}
