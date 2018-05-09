using KafeOtomasyonu.DAL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.BLL
{
    public class BLLKategori
    {
        public static string Ekle(EKategori yeniKategori)
        {            
            if (yeniKategori.CategoryName != "")
            {
                if (DALKategori.Ekle(yeniKategori) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı kategoriden var, farklı bir isim giriniz...";
                }
                
            }
            return "Hatalı işlem...";
        }
        public static List<EKategori> Listele()
        {
            return DALKategori.Listele();
        }


        public static EKategori KategoriBul(int id)
        {
            return DALKategori.KategoriBul(id);
        }

        public static string Sil(EKategori k)
        {
            if (k.ID > 0)
            {
                DALKategori.Sil(k);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }

        public static string Duzenle(EKategori k)
        {
            if (k.ID <= 0 || k.CategoryName == "")
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALKategori.Duzenle(k);
                return "Düzenlendi...";
            }
        }
    }
}
