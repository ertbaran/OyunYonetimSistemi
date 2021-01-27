using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OyunYonetimSistemi.MernisServiceReference;
namespace OyunYonetimSistemi
{
    public class Oyuncu : IOyuncuManager
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TCN { get; set; }
        public int DogumYili { get; set; }

        public void YeniKayit(List<Oyuncu> oyuncular)
        {
            KPSPublicSoapClient mernisService = new KPSPublicSoapClient();
            int yeniNumara = 0;
            if (oyuncular.Count == 0)
            {
                Oyuncu oyuncu = new Oyuncu();
                oyuncular.Add(oyuncu);
            }
            for (int i = 0; i < oyuncular.Count; i++)
            {
                if (oyuncular[i] == null)
                {
                    yeniNumara = i;
                    break;
                }
            }

            Console.WriteLine("TC Numaranız: ");
            oyuncular[yeniNumara].TCN = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Adınız: ");
            oyuncular[yeniNumara].Ad = Console.ReadLine();

            Console.WriteLine("Soyadınız: ");
            oyuncular[yeniNumara].Soyad = Console.ReadLine();

            Console.WriteLine("Doğum Tarihiniz: ");
            oyuncular[yeniNumara].DogumYili = Convert.ToInt16(Console.ReadLine());

            if (mernisService.TCKimlikNoDogrula(oyuncular[yeniNumara].TCN, oyuncular[yeniNumara].Ad, oyuncular[yeniNumara].Soyad, oyuncular[yeniNumara].DogumYili))
            {
                Console.WriteLine("Kayıt Başarılı.");
            }
            else
            {
                Console.WriteLine("Kimlik bilgileri hatalı !");
                YeniKayit(oyuncular);
            }

        }
        public void Guncelle(List<Oyuncu> oyuncular)
        {
            Console.WriteLine("Güncellenecek kişinin TC No giriniz: ");
            float tcNo = Convert.ToSingle(Console.ReadLine());

            for (int i = 0; i < oyuncular.Count; i++)
            {
                if (oyuncular[i].TCN == tcNo)
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Güncelleme için yeni bilgilerinizi giriniz.");
                    Console.WriteLine("____________________________________");

                    Console.WriteLine("Adınız: ");
                    oyuncular[i].Ad = Console.ReadLine();

                    Console.WriteLine("Soyadınız: ");
                    oyuncular[i].Soyad = Console.ReadLine();

                    Console.WriteLine("Doğum Tarihiniz: ");
                    oyuncular[i].DogumYili = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Bilgileriniz Güncellendi.");
                }
                else
                    Console.WriteLine("-----Oyuncu bulunamadı.-----");
            }
        }

        public void Sil(List<Oyuncu> oyuncular)
        {
            Console.WriteLine("Kaydı silinecek kişinin TC No: ");
            long tcNo = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < oyuncular.Count; i++)
            {
                if (oyuncular[i].TCN == tcNo)
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine(oyuncular[i].Ad.ToUpper()+" "+oyuncular[i].Soyad.ToUpper() +" kaydı başarıyla silindi.");
                    Console.WriteLine("____________________________________");

                    oyuncular.Remove(oyuncular[i]);
                }
                else
                    Console.WriteLine("-----Oyuncu bulunamadı.-----");
            }
        }
    }
}
