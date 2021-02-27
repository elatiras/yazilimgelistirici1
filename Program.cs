using System;

namespace yazilimgelistirici1
{
    class Program
    {
        static void Main(string[] args)
        {

            metotlar1.Urun urun1 = new metotlar1.Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            metotlar1.Urun urun2 = new metotlar1.Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Ballı lokma tatlısı";

            metotlar1.Urun[] urunler = new metotlar1.Urun[] { urun1, urun2 };

            foreach (metotlar1.Urun  urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");

            }
            Console.WriteLine("--------Metotlar------");

            metotlar1.sepetmanager sepetmanager = new metotlar1.sepetmanager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12,8);

        }
    }
}


