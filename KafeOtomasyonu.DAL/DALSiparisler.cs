using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    public class DALSiparisler
    {
        public static List<ESiparisler> SiparisleriBul(string masaAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_SiparisleriBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("masaAdi", masaAdi);
            SqlDataReader dr = cmd.ExecuteReader();
            List<ESiparisler> sListe = new List<ESiparisler>();
            while (dr.Read())
            {
                ESiparisler s = new ESiparisler();
                s.ProductName = dr["ProductName"].ToString();
                s.Quantity = Convert.ToInt32(dr["Quantity"]);
                sListe.Add(s);
            }
            dr.Close();
            baglanti.conn.Close();
            return sListe;
        }

        public static void Ekle(string masaAdi, ESiparisler s)
        {
            int urunID = DALUrun.UrunBul(s.ProductName).ID;
            int masaID = DALMasa.MasaBul(masaAdi).ID;
            SqlCommand cmd = new SqlCommand("sp_SiparisEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("masaID", masaID);
            cmd.Parameters.AddWithValue("urunID", urunID);
            cmd.Parameters.AddWithValue("miktar", s.Quantity);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        //public static ESiparisler SiparisBul(string masaAdi, string urunAdi)
        //{
        //    SqlCommand cmd = new SqlCommand("select * from TableProducts")
        //}

        public static void SiparisSil(string urunAdi, string masaAdi)
        {
            int urunID = DALUrun.UrunBul(urunAdi).ID;
            int masaID = DALMasa.MasaBul(masaAdi).ID;
            SqlCommand cmd = new SqlCommand("sp_SiparisSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("masaID", masaID);
            cmd.Parameters.AddWithValue("urunID", urunID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void MasaBosalt(string masaAdi)
        {
            int masaID = DALMasa.MasaBul(masaAdi).ID;
            SqlCommand cmd = new SqlCommand("sp_MasaBosalt", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("masaID", masaID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
