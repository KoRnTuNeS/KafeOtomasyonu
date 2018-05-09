using KafeOtomasyonu.DAL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.BLL
{
    public class BLLMasa
    {
        //public static void MasalariOlustur()
        //{            
        //    for (int i = 1; i <= 50; i++)
        //    {
        //        DALMasa.MasalariOlustur(i);
        //    }
        //}
        public static List<EMasa> Listele()
        {
            return DALMasa.Listele();
        }

        public static EMasa MasaBul(string masaAdi)
        {
            return DALMasa.MasaBul(masaAdi);
        }
        //public static ArrayList SiparisleriBul(string masaAdi)
        //{
        //    return DALMasa.SiparisleriBul(masaAdi);
        //}
    }
}
