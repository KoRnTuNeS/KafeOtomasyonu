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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = BLLKategori.Listele();
            cmbKategori.DisplayMember = "CategoryName";
            cmbKategori.ValueMember = "ID";


            Doldur();
        }

        private void Doldur()
        {
            lvUrunListe.Items.Clear();
            foreach (EUrun item in BLLUrun.Listele())
            {

                ListViewItem lvi = new ListViewItem();
                string kat = BLLUrun.KategoriBul(item);
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(kat);
                lvi.SubItems.Add(item.ProductName.ToString());
                lvi.SubItems.Add(item.Price.ToString());

                lvUrunListe.Items.Add(lvi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EUrun u = new EUrun();
            u.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue);
            u.ProductName = txtUrunAdi.Text;
            u.Price = Convert.ToDecimal(numFiyat.Value);
            string cevap = BLLUrun.Ekle(u);
            MessageBox.Show(cevap);
            Doldur();
        }

        int urunid;
        private void lvUrunListe_DoubleClick(object sender, EventArgs e)
        {
            urunid = Convert.ToInt32(lvUrunListe.SelectedItems[0].SubItems[0].Text);            
            EUrun u = BLLUrun.UrunBul(urunid);
            cmbKategori.SelectedValue = u.CategoryID;
            txtUrunAdi.Text = u.ProductName;
            numFiyat.Value = u.Price;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EUrun u = BLLUrun.UrunBul(urunid);
            string cevap = BLLUrun.Sil(u);
            MessageBox.Show(cevap);
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EUrun u = BLLUrun.UrunBul(urunid);
            u.CategoryID = Convert.ToInt32(cmbKategori.SelectedValue);
            u.ProductName = txtUrunAdi.Text;
            u.Price = Convert.ToDecimal(numFiyat.Value);
            string cevap = BLLUrun.Duzenle(u);
            MessageBox.Show(cevap);
            Doldur();
        }
    }
}
