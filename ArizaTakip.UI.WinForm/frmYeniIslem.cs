using ArizaTakip.BLL;
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
    public partial class frmYeniIslem : Form
    {
        MusteriBLL _musteriBLL;
        ArizaBLL _arizaBLL;
        IslemBLL _islemBLL;
        int _personelID;
        public frmYeniIslem(int personelID)
        {
            InitializeComponent();
            _musteriBLL = new MusteriBLL();
            _arizaBLL = new ArizaBLL();
            _islemBLL = new IslemBLL();
            _personelID = personelID;
        }

        private void frmYeniIslem_Load(object sender, EventArgs e)
        {
            List<Ariza> arizalar = _arizaBLL.GetAll();
            cmbAriza.DisplayMember = "Tanim";
            cmbAriza.ValueMember = "ArizaID";
            cmbAriza.DataSource = arizalar;

            List<Musteri> musteriler = _musteriBLL.GetAll();
            cmbMusteri.DisplayMember = "AdSoyad";
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DataSource = musteriler;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Islem yeniIslem = new Islem();
            yeniIslem.ArizaID = (int)cmbAriza.SelectedValue;
            yeniIslem.MusteriID = (int)cmbMusteri.SelectedValue;
            yeniIslem.PersonelID = _personelID;

            bool sonuc = _islemBLL.Add(yeniIslem);
            if (sonuc)
            {
                MessageBox.Show("İşlem eklendi");
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }
    }
}
