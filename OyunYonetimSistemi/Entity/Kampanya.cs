using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYonetimSistemi
{
    public class Kampanya : IKampanyaManager
    {
        public int IndirimYuzdesi { get; set; }
        public string OyunAdi { get; set; }
        public void YeniKayit(List<Kampanya> kampanyalar, List<Oyun> oyunlar)
        {
            int yeniNumara = 0;
            if (kampanyalar.Count == 0)
            {
                Kampanya kampanya = new Kampanya();
                kampanyalar.Add(kampanya);
            }
            for (int i = 0; i < kampanyalar.Count; i++)
            {
                if (kampanyalar[i] == null)
                {
                    yeniNumara = i;
                    break;
                }
            }

            Console.WriteLine("Kampanya yapılacak oyunun numarasını giriniz: ");
            int oyunNo = Convert.ToInt32(Console.ReadLine());
            if (oyunNo < 4 || oyunNo > 0)
            {
                Console.WriteLine("İndirim yüzdesi girin: ");
                IndirimYuzdesi = Convert.ToInt32(Console.ReadLine());
                oyunlar[oyunNo - 1].OyunFiyati -= IndirimYuzdesi * oyunlar[oyunNo - 1].OyunFiyati / 100;

                Kampanya kampanya = new Kampanya();
                kampanya.OyunAdi = oyunlar[oyunNo - 1].OyunAdi;
                kampanya.IndirimYuzdesi = IndirimYuzdesi;
                kampanyalar.Add(kampanya);

                Console.WriteLine("-----Kampanya Eklendi.------");
            }
            else
                Console.WriteLine("-----Hatalı giriş yapıldı.-----");

        }
        public void Guncelle(List<Kampanya> kampanyalar, List<Oyun> oyunlar)
        {
            for (int i = 0; i < kampanyalar.Count; i++)
            {
                if (kampanyalar[i].IndirimYuzdesi != 0)
                {
                    Console.WriteLine(i+")"+kampanyalar[i].OyunAdi + " %" + kampanyalar[i].IndirimYuzdesi + " indirim");
                }
            }
        }

        public void Sil(List<Kampanya> kampanyalar, List<Oyun> oyunlar)
        {
            for (int i = 0; i < kampanyalar.Count; i++)
            {
                if (kampanyalar[i].IndirimYuzdesi != 0)
                {
                    Console.WriteLine(i+") "+kampanyalar[i].OyunAdi + " %" + kampanyalar[i].IndirimYuzdesi + " indirim");
                }
            }
            Console.WriteLine("Silinecek kampanya numarasını yazın: ");
            int kampNo = Convert.ToInt32(Console.ReadLine());
            kampanyalar.Remove(kampanyalar[kampNo - 1]);
            Console.WriteLine("-----Kampanya silindi-----");
        }
    }
}
