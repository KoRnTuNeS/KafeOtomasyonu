using KafeOtomasyonu.DAL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.BLL
{
    public class BLLSiparisler
    {
        public static List<ESiparisler> SiparisleriBul(string masaAdi)
        {
            return DALSiparisler.SiparisleriBul(masaAdi);
        }

        public static string Ekle(string masaAdi, ESiparisler s)
        {
            if (s.ProductName == "" || s.Quantity < 0)
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALSiparisler.Ekle(masaAdi, s);
                return "Eklendi...";
            }
        }

        //public static ESiparisler SiparisBul(string masaAdi, string urunAdi)
        //{
        //    return DALSiparisler.SiparisBul(masaAdi, urunAdi);
        //}

        public static string SiparisSil(string urunAdi, string masaAdi)
        {
            if (urunAdi != null && masaAdi != null)
            {
                DALSiparisler.SiparisSil(urunAdi, masaAdi);
                return "Silindi...";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string MasaBosalt(string masaAdi)
        {
            if (masaAdi != null)
            {
                DALSiparisler.MasaBosalt(masaAdi);
                return "Masa boşaltıldı...";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }
    }
}
