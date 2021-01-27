using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunYonetimSistemi
{
    public interface IOyuncuManager
    {
        void YeniKayit(List<Oyuncu> oyuncular);
        void Guncelle(List<Oyuncu> oyuncular);
        void Sil(List<Oyuncu> oyuncular);
    }
}
