using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Musteri[] musteriler = new Musteri[3];
        List<Musteri> musteriler = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Eklenen musteri: "+musteri.Ad+" "+musteri.SoyAd);
        }

        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Silinen musteri: " + musteri.Ad + " " + musteri.SoyAd);
        }

        public void Listele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id : " + musteri.Id);
                Console.WriteLine("Ad :" + musteri.Ad);
                Console.WriteLine("Soyad :" + musteri.SoyAd);
                Console.WriteLine("-----------------------------");
            }

        }
    }
}
