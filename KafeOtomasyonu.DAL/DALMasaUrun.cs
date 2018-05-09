using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    public class DALMasaUrun
    {
        public static decimal ToplamSiparis(string masaAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_ToplamSiparis", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("masaAdi", masaAdi);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            decimal toplam = 0;
            while (dr.Read())
            {
                toplam = Convert.ToDecimal(dr["Toplam"]);
            }
            dr.Close();
            baglanti.conn.Close();
            return toplam;
        }

        public static void Aktar(int aktarilacakMasa, int aktarildigiMasa)
        {
            SqlCommand cmd = new SqlCommand("sp_IlkMasaBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ilkMasa", aktarilacakMasa);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMasaUrun> ilkListe = new List<EMasaUrun>();
            while (dr.Read())
            {
                EMasaUrun mu = new EMasaUrun();
                mu.ID = Convert.ToInt32(dr["ID"]);
                mu.ProductID = Convert.ToInt32(dr["ProductID"]);
                mu.TableID = Convert.ToInt32(dr["TableID"]);
                mu.Quantity = Convert.ToInt32(dr["Quantity"]);
                ilkListe.Add(mu);
            }
            dr.Close();
            baglanti.conn.Close();

            SqlCommand cmd2 = new SqlCommand("sp_IlkMasaBul", baglanti.conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("ilkMasa", aktarildigiMasa);
            baglanti.conn.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            List<EMasaUrun> sonListe = new List<EMasaUrun>();
            while (dr2.Read())
            {
                EMasaUrun mu2 = new EMasaUrun();
                mu2.ID = Convert.ToInt32(dr2["ID"]);
                mu2.ProductID = Convert.ToInt32(dr2["ProductID"]);
                mu2.TableID = Convert.ToInt32(dr2["TableID"]);
                mu2.Quantity = Convert.ToInt32(dr2["Quantity"]);
                sonListe.Add(mu2);
            }
            dr2.Close();
            baglanti.conn.Close();

            foreach (EMasaUrun item in ilkListe)
            {
                SqlCommand cmd3 = new SqlCommand("sp_MasaAktar", baglanti.conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("yeniID", aktarildigiMasa);
                cmd3.Parameters.AddWithValue("id", item.ID);
                baglanti.conn.Open();
                cmd3.ExecuteNonQuery();
                baglanti.conn.Close();
            }

            foreach (EMasaUrun item in sonListe)
            {
                SqlCommand cmd4 = new SqlCommand("sp_MasaAktar", baglanti.conn);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("yeniID", aktarilacakMasa);
                cmd4.Parameters.AddWithValue("id", item.ID);
                baglanti.conn.Open();
                cmd4.ExecuteNonQuery();
                baglanti.conn.Close();
            }
        }
    }
}
