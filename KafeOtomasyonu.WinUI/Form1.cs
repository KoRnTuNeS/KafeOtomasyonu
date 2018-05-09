using KafeOtomasyonu.BLL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KafeOtomasyonu.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            frmKategori f = new frmKategori();
            f.Show();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            frmUrun f = new frmUrun();
            f.Show();
        }
        public void Doldur()
        {
            lviMasalar.Items.Clear();
            foreach (EMasa item in BLLMasa.Listele())
            {
                
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.TableName.ToString();
                lvi.SubItems.Add(BLLMasaUrun.ToplamSiparis(item.TableName).ToString("c2"));

                lviMasalar.Items.Add(lvi);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        public static string masaAdi;
        private void lviMasalar_DoubleClick(object sender, EventArgs e)
        {
            masaAdi = lviMasalar.SelectedItems[0].SubItems[0].Text;
            frmMasaDetay f = new frmMasaDetay();
            f.Show();
        }
    }
}
