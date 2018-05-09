using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KafeOtomasyonu.DAL
{
    public class DALMasa
    {
        //public static void MasalariOlustur(int masaNo)
        //{
        //    SqlCommand cmd = new SqlCommand("Insert into Tables (TableName) values (@masaAdi)", baglanti.conn);
        //    string masaNosu = "M" + masaNo;
        //    cmd.Parameters.AddWithValue("masaAdi", masaNosu);
        //    baglanti.conn.Open();
        //    cmd.ExecuteNonQuery();
        //    baglanti.conn.Close();
        //}
        public static List<EMasa> Listele()
        {
            SqlCommand cmd = new SqlCommand("sp_MasaListele", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<EMasa> liste = new List<EMasa>();
            while (dr.Read())
            {
                EMasa m = new EMasa();
                m.ID = Convert.ToInt32(dr["ID"]);
                m.TableName = dr["TableName"].ToString();
                liste.Add(m);
            }
            dr.Close();
            baglanti.conn.Close();
            return liste;
        }
        
        public static EMasa MasaBul(string masaAdi)
        {
            SqlCommand cmd = new SqlCommand("sp_MasaBul", baglanti.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            baglanti.conn.Open();
            cmd.Parameters.AddWithValue("masaAdi", masaAdi);
            SqlDataReader dr = cmd.ExecuteReader();
            EMasa m = new EMasa();
            while (dr.Read())
            {
                m.ID = Convert.ToInt32(dr["ID"]);
                m.TableName = dr["TableName"].ToString();
            }
            dr.Close();
            baglanti.conn.Close();
            return m;
        }
        //public static ArrayList SiparisleriBul(string masaAdi)
        //{
        //    SqlCommand cmd = new SqlCommand("select ProductName, Quantity from Products p inner join TableProducts tp on p.ID = tp.ProductID inner join Tables t on t.ID = tp.TableID where TableName = @masaAdi",baglanti.conn);
        //    baglanti.conn.Open();
        //    cmd.Parameters.AddWithValue("masaAdi", masaAdi);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    ArrayList dizi = new ArrayList();
        //    while (dr.Read())
        //    {
        //        dizi.Add(dr["ProductName"].ToString());
        //        dizi.Add(Convert.ToInt32(dr["Quantity"]));
        //    }
        //    dr.Close();
        //    baglanti.conn.Close();
        //    return dizi;
        //}
    }
}
