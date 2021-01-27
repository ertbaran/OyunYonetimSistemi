using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYonetimSistemi
{
    public interface IKampanyaManager
    {
        void YeniKayit(List<Kampanya> kampanyalar, List<Oyun> oyunlar);
        void Guncelle(List<Kampanya> kampanyalar, List<Oyun> oyunlar);
        void Sil(List<Kampanya> kampanyalar, List<Oyun> oyunlar);
    }
}
