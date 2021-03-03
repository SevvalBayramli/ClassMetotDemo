using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Merve";
            musteri1.SoyAd = "Kalem";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Selim";
            musteri2.SoyAd = "Doruk";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Derya";
            musteri3.SoyAd = "Deniz";
            musteri3.Id = 3;

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-----------------------------------");

            //musteriManager.Listele();

            Console.WriteLine("------------------------------------");

            musteriManager.Sil(musteri2);

            musteriManager.Listele();

            Console.WriteLine("------------------------------------");

        }
    }
}
