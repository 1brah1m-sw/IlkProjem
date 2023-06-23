namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double Fiyatı = 15;
            string Acıklamasi = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklamasi = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = " Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklamasi = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)

            {
                Console.WriteLine(urun.Adi );
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklamasi);
                Console.WriteLine("...................");
            }
            Console.WriteLine("...........Metotlar..................");

            // instance = class örneği
            // encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2); 
           
            sepetManager.Ekle2("Elma", "Amasya elması", 15, 10);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,9);

            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80,8);




        }
    }      
} 
  //Dont repeat yourself - DRY - Clean Code - Best Practice