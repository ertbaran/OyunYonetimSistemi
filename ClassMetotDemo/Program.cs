using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri[] musteriler = new Musteri[10];
            MusteriManager.MusteriEkle("12345678910", "Ertuğrul", "Baran", musteriler);
            MusteriManager.MusteriEkle("12345678911", "Cahit", "Zarifoğlu", musteriler);
            MusteriManager.MusteriEkle("12345678912", "Halide Edip", "Adıvar", musteriler);
            MusteriManager.MusteriListele(musteriler);
            MusteriManager.MusteriSil(musteriler, "12345678910");
            MusteriManager.MusteriListele(musteriler);
            MusteriManager.MusteriEkle("12345678910", "Ertuğrul", "Baran", musteriler);
            MusteriManager.MusteriListele(musteriler);

            Console.Read();
        }
    }
}