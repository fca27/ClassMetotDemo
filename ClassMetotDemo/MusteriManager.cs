using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("müşteri eklendi");
            Console.WriteLine("eklenen müşteri: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusterileriListele(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("müşteri silindi");
            Console.WriteLine("silinen müşteri: " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
