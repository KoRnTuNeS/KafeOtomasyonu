using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    public class DALKategori
    {
        public static int Ekle(EKategori paket)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@katAdi", paket.CategoryName);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
        }
        public static List<EKategori> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EKategori> Liste = new List<EKategori>();
            while (dr.Read())
            {
                EKategori k = new EKategori();
                k.ID = Convert.ToInt32(dr["ID"]);
                k.CategoryName = dr["CategoryName"].ToString();
                Liste.Add(k);
            }
            dr.Close();
            baglanti.conn.Close();
            return Liste;
        }

        public static EKategori KategoriBul(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("katID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            EKategori k = new EKategori();
            while (dr.Read())
            {
                k.ID = Convert.ToInt32(dr["ID"]);
                k.CategoryName = dr["CategoryName"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return k;
        }

        public static void Sil(EKategori k)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", k.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Duzenle(EKategori k)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("katAdi", k.CategoryName);
            cmd.Parameters.AddWithValue("id", k.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
