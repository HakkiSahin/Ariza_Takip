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
    public partial class frmIslem : Form
    {
        IslemBLL _islemBLL;
        Personel _suAnkiPersonel;
        public frmIslem(Personel p)
        {
            InitializeComponent();
            _islemBLL = new IslemBLL();
            _suAnkiPersonel = p;
        }

        private void frmIslem_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _islemBLL.GetAllByPersonel(_suAnkiPersonel.PersonelID);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmYeniIslem frm = new frmYeniIslem(_suAnkiPersonel.PersonelID);
            frm.ShowDialog();
        }

        private void frmIslem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
