using KafeOtomasyonu.BLL;
using KafeOtomasyonu.EntityLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KafeOtomasyonu.WinUI
{
    public partial class frmMasaDetay : Form
    {
        public frmMasaDetay()
        {
            InitializeComponent();
        }
        string masaAdi = Form1.masaAdi;
        public void Doldur()
        {
            lvSiparisler.Items.Clear();
            EMasa m = BLLMasa.MasaBul(Form1.masaAdi);
            foreach (ESiparisler item in BLLSiparisler.SiparisleriBul(m.TableName))
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ProductName.ToString();
                lvi.SubItems.Add(item.Quantity.ToString());

                lvSiparisler.Items.Add(lvi);
            }
            lblToplam.Text = BLLMasaUrun.ToplamSiparis(m.TableName).ToString("c2");
        }
        private void frmMasaDetay_Load(object sender, EventArgs e)
        {
            Doldur();
            cmbMasalar.DataSource = BLLMasa.Listele();
            cmbMasalar.DisplayMember = "TableName";
            cmbMasalar.ValueMember = "ID";
            btnSil.Enabled = false;
            cmbMasalar.Enabled = false;
            btnAktar.Enabled = false;
            chkAktar.Checked = false;
            
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            frmSiparisEkle f = new frmSiparisEkle();
            f.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //string masaAdi = Form1.masaAdi;

            string cevap = BLLSiparisler.SiparisSil(urunAdi, masaAdi);
            MessageBox.Show(cevap);
            Doldur();
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Doldur();
        }
        string urunAdi;
        private void lvSiparisler_DoubleClick(object sender, EventArgs e)
        {
            urunAdi = lvSiparisler.SelectedItems[0].SubItems[0].Text;
            btnSil.Enabled = true;
        }

        private void btnBosalt_Click(object sender, EventArgs e)
        {
            string cevap = BLLSiparisler.MasaBosalt(masaAdi);
            MessageBox.Show(cevap);
            Doldur();
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Doldur();
        }

        private void chkAktar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAktar.Checked)
            {
                btnAktar.Enabled = true;
                cmbMasalar.Enabled = true;
            }
            else
            {
                btnAktar.Enabled = false;
                cmbMasalar.Enabled = false;
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            int aktarilacakMasa = BLLMasa.MasaBul(masaAdi).ID;
            int aktarildigiMasa = Convert.ToInt32(cmbMasalar.SelectedValue);
            string cevap = BLLMasaUrun.Aktar(aktarilacakMasa, aktarildigiMasa);
            MessageBox.Show(cevap);
            Doldur();
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Doldur();
        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            EMasa m = BLLMasa.MasaBul(Form1.masaAdi);

            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
            int i = 1;
            int j = 1;
            foreach (ListViewItem item in lvSiparisler.Items)
            {
                ws.Cells[i, j] = item.Text.ToString();
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    ws.Cells[i, j] = subitem.Text.ToString();
                    j++;

                    ws.Cells[i + 1, 1] = "Toplam: " + BLLMasaUrun.ToplamSiparis(m.TableName).ToString("c2");
                }
                j = 1;
                i++;
            }
        }
    }
}
