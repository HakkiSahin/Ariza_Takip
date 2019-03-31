using ArizaTakip.BLL;
using ArizaTakip.DTO;
using ArizaTakip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArizaTakip.UI.WinForm
{
    public partial class frmMain : Form
    {
        IslemBLL _islemBLL;
        Personel _personel;

        public frmMain()
        {
            InitializeComponent();
            _islemBLL = new IslemBLL();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtISlemNo.Text))
            {
                MessageBox.Show("Lütfen bir işlem numarası girin");
                return;
            }

            int islemNo = int.Parse(txtISlemNo.Text);
            IslemDTO arananIslem = _islemBLL.GetAllDataByID(islemNo);
            txtSonuc.Text = $"{arananIslem.Islem.IslemNo} numaralı arıza {arananIslem.Islem.AlinanTarih} tarihinde {arananIslem.Ariza.Tanim} arızasıyla işleme alınmıştır. Şu an için durum : {arananIslem.Durum.Ad}";
        }

        public void IslemlerGoster(Personel p)
        {
            linkLabel2.Visible = true;
            linkLabel1.Visible = false;
            _personel = p;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmIslem frm = new frmIslem(_personel);
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

    }
}
