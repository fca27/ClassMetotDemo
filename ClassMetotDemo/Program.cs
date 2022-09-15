using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1; 
            musteri1.Ad = "betül";
            musteri1.Soyad = "akbaba";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad="furkan";
            musteri2.Soyad = "akbaba";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "ali";
            musteri3.Soyad = "veli";

            List<Musteri> musteriler = new List<Musteri>();
            musteriler.Add(musteri1);
            musteriler.Add(musteri2);

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri3);

            musteriManager.MusterileriListele(musteriler);
;
        }
    }
}
