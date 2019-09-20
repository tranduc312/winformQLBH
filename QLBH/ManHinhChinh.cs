using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }


        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Show();
        }

        private void Btqlban_Click(object sender, EventArgs e)
        {
            QLBAN qlb = new QLBAN();
            this.Hide();
            qlb.ShowDialog();
            this.Show();
        }

        private void Btqlsanpham_Click(object sender, EventArgs e)
        {
            QlSANPHAM qlsp = new QlSANPHAM();
            this.Hide();
            qlsp.ShowDialog();
            this.Show();
        }

        private void Bthoadon_Click(object sender, EventArgs e)
        {
            QLHOADON qlhd = new QLHOADON();
            this.Hide();
            qlhd.ShowDialog();
            this.Show();
        }

        private void Btqltaikhoan_Click(object sender, EventArgs e)
        {
            QLTAIKHOAN qltk = new QLTAIKHOAN();
            this.Hide();
            qltk.ShowDialog();
            this.Show();
        }

        private void ThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAOCAO baocao = new BAOCAO();
            this.Hide();
            baocao.ShowDialog();
            this.Show();
        }
    }
}
