using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void MusteriEkle(string tcNo, string ad, string soyad, Musteri[] musteriler)
        {
            Musteri musteri = new Musteri();
            for (int i = 0; i < musteriler.Length; i++)
            {
                if (musteriler[i] == null)
                {
                    musteriler[i] = musteri;
                    musteri.TC = tcNo;
                    musteri.Ad = ad;
                    musteri.Soyad = soyad;
                    Console.WriteLine(musteri.TC + " | " + musteri.Ad + " " + musteri.Soyad + " kişisi eklendi. ");
                    break;
                }
            }
        }

        public static void MusteriListele(Musteri[] musteriler)
        {
            Console.WriteLine("_____________________________________\n" +
                "Güncel Müşteri Listesi:\n");
            foreach (var musteri in musteriler)
            {
                if (musteri != null)
                {
                    Console.WriteLine(musteri.TC + " " + musteri.Ad + " " + musteri.Soyad);
                }
            }
            Console.WriteLine("_____________________________________");
        }

        public static void MusteriSil(Musteri[] musteriler, string tcNo)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                if (musteriler[i] != null && musteriler[i].TC == tcNo)
                {
                    Array.Clear(musteriler, i, 1);
                    Console.WriteLine(tcNo + " TC numaralı müşteri silindi.");
                    break;
                }
                else if (i == musteriler.Length-1 && musteriler[i]==null)
                {
                    Console.WriteLine("Müşteri bulunamadı.");
                }
            }
        }
    }
}
