using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QLBH
{
    public partial class QLTAIKHOAN : Form
    {
        BLL_TAIKHOAN tkbll = new BLL_TAIKHOAN();
        public QLTAIKHOAN()
        {
            InitializeComponent();
        }

        private void Btthemtk_Click(object sender, EventArgs e)
        {
            tkbll.TAIKHOAN_Insert(tbtaikhoan.Text, tbmatkhau.Text, cbloaitk.Text);
            MessageBox.Show("Thêm Thành công");
            tbtaikhoan.Clear();
            tbmatkhau.Clear();
            Bthienthitk_Click(sender, e);
        }

        private void Btsuatk_Click(object sender, EventArgs e)
        {
            tkbll.TAIKHOAN_Update(tbtaikhoan.Text, tbmatkhau.Text, cbloaitk.Text);
            MessageBox.Show("Thay đổi thành công");
            tbtaikhoan.Clear();
            tbmatkhau.Clear();
            Bthienthitk_Click(sender, e);
        }

        private void Btxoatk_Click(object sender, EventArgs e)
        {
            tkbll.TAIKHOAN_Delete(tbtaikhoan.Text);
            MessageBox.Show("Xóa thành công");
            tbtaikhoan.Clear();
            tbmatkhau.Clear();
            Bthienthitk_Click(sender, e);
        }

        private void Bthienthitk_Click(object sender, EventArgs e)
        {
            dtgvTK.DataSource = tkbll.TAIKHOAN_Select();
        }

        private void DtgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbtaikhoan.Text = dtgvTK.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbmatkhau.Text = dtgvTK.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbloaitk.Text = dtgvTK.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Bttimkiemtk_Click(object sender, EventArgs e)
        {
            dtgvTK.DataSource = tkbll.TAIKHOAN_Select_where(tbtimkiemtk.Text);
        }

        private void Btquaylai_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            this.Hide();
            mhc.ShowDialog();
        }
    }
}
