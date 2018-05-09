using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    public class DALUrun
    {
        public static int Ekle(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunEkle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@katID", u.CategoryID);
            cmd.Parameters.AddWithValue("@urunAdi", u.ProductName);
            cmd.Parameters.AddWithValue("@fiyat", u.Price);
            baglanti.conn.Open();
            int sayi = cmd.ExecuteNonQuery();
            baglanti.conn.Close();
            return sayi;
            
        }
        public static List<EUrun> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_UrunListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EUrun> liste = new List<EUrun>();
            while (dr.Read())
            {
                EUrun u = new EUrun();
                u.ID = Convert.ToInt32(dr["ID"]);
                u.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"]);
                liste.Add(u);
            }
            dr.Close();
            baglanti.conn.Close();
            return liste;
        }
        public static List<EUrun> Listele(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriUrunListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("katID", id);
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EUrun> liste = new List<EUrun>();
            while (dr.Read())
            {
                EUrun u = new EUrun();
                u.ID = Convert.ToInt32(dr["ID"]);
                u.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"]);
                liste.Add(u);
            }
            dr.Close();
            baglanti.conn.Close();
            return liste;
        }
        public static string KategoriBul(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_KategoriBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("@katID", u.CategoryID);
            SqlDataReader dr = cmd.ExecuteReader();
            string kategoriAdi = "";
            while (dr.Read())
            {
                kategoriAdi = dr["CategoryName"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return kategoriAdi;
        }
        public static EUrun UrunBul(int id)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("proID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            EUrun u = new EUrun();
            while (dr.Read())
            {
                u.ID = Convert.ToInt32(dr["ID"]);
                u.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"]);
            }
            dr.Close();
            baglanti.conn.Close();
            return u;
        }
        public static EUrun UrunBul(string urunAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunBulString", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("urunAdi", urunAdi);
            SqlDataReader dr = cmd.ExecuteReader();
            EUrun u = new EUrun();
            while (dr.Read())
            {
                u.ID = Convert.ToInt32(dr["ID"]);
                u.CategoryID = Convert.ToInt32(dr["CategoryID"]);
                u.ProductName = dr["ProductName"].ToString();
                u.Price = Convert.ToDecimal(dr["Price"]);
            }
            dr.Close();
            baglanti.conn.Close();
            return u;
        }

        public static void Duzenle(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunDuzenle", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.ID);
            cmd.Parameters.AddWithValue("@katID", u.CategoryID);
            cmd.Parameters.AddWithValue("@urunAdi", u.ProductName);
            cmd.Parameters.AddWithValue("@fiyat", u.Price);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }

        public static void Sil(EUrun u)
        {
            SqlCommand cmd = new SqlCommand("sp_UrunSil", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", u.ID);
            baglanti.conn.Open();
            cmd.ExecuteNonQuery();
            baglanti.conn.Close();
        }
    }
}
