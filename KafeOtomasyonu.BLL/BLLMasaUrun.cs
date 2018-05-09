using KafeOtomasyonu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.BLL
{
    public class BLLMasaUrun
    {
        public static decimal ToplamSiparis(string masaAdi)
        {
            return DALMasaUrun.ToplamSiparis(masaAdi);
        }

        public static string Aktar(int aktarilacakMasa, int aktarildigiMasa)
        {
            if (aktarilacakMasa > 0 && aktarildigiMasa > 0)
            {
                DALMasaUrun.Aktar(aktarilacakMasa, aktarildigiMasa);
                return "Aktarıldı";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }
    }
}
