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
    public partial class frmLogin : Form
    {
        PersonelBLL _personelBLL;

        public frmLogin()
        {
            InitializeComponent();
            _personelBLL = new PersonelBLL();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Personel girisYapanPersonel = _personelBLL.GetByLogin(txtKullaniciAdi.Text, txtSifre.Text);
            if (girisYapanPersonel != null)
            {
                ((frmMain)this.Owner).IslemlerGoster(girisYapanPersonel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }
    }
}
