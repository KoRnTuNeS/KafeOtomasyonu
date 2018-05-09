using KafeOtomasyonu.DAL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.BLL
{
    public class BLLUrun
    {
        public static string Ekle(EUrun urun)
        {            
            if (urun.ProductName == "" || urun.CategoryID == 0 || urun.Price < 0)
            {
                return "Hatalı işlem...";
            }
            else
            {
                if (DALUrun.Ekle(urun) > 0)
                {
                    return "Eklendi...";
                }
                else
                {
                    return "Aynı kategoriden var, farklı bir isim giriniz...";
                }                
            }
        }
        public static List<EUrun> Listele()
        {
            return DALUrun.Listele();
        }
        public static List<EUrun> Listele(int id)
        {
            return DALUrun.Listele(id);
        }

        public static string KategoriBul(EUrun item)
        {
            return DALUrun.KategoriBul(item);
        }
        public static EUrun UrunBul(int id)
        {
            return DALUrun.UrunBul(id);
        }

        public static string Duzenle(EUrun u)
        {
            if (u.ID <= 0 || u.ProductName == "" || u.CategoryID == 0 || u.Price < 0)
            {
                return "Hatalı işlem...";
            }
            else
            {
                DALUrun.Duzenle(u);
                return "Düzenlendi...";
            }
        }

        public static string Sil(EUrun u)
        {
            if (u.ID > 0)
            {
                DALUrun.Sil(u);
                return "Silindi";
            }
            else
            {
                return "Hatalı işlem...";
            }
        }
    }
}
