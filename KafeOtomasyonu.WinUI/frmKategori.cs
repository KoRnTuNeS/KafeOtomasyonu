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
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        private void Doldur()
        {
            lvKategoriler.Items.Clear();
            foreach (EKategori item in BLLKategori.Listele())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.CategoryName.ToString());

                lvKategoriler.Items.Add(lvi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKategori k = new EKategori();
            k.CategoryName = txtKategoriAdi.Text;
            string cevap = BLLKategori.Ekle(k);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        int katID;
        private void lvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            katID = Convert.ToInt32(lvKategoriler.SelectedItems[0].SubItems[0].Text);
            EKategori k = BLLKategori.KategoriBul(katID);
            txtKategoriAdi.Text = k.CategoryName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EKategori k = BLLKategori.KategoriBul(katID);
            string cevap = BLLKategori.Sil(k);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EKategori k = BLLKategori.KategoriBul(katID);
            k.CategoryName = txtKategoriAdi.Text;
            string cevap = BLLKategori.Duzenle(k);
            MessageBox.Show(cevap);
            Doldur();
        }
    }
}
