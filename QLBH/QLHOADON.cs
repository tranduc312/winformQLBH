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
    public partial class QLHOADON : Form
    {
        BLL_HOADON hdbll = new BLL_HOADON();
        BLL_CTHD cthdbll = new BLL_CTHD();
        public QLHOADON()
        {
            InitializeComponent();
        }

        private void Bthienthihd_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource = hdbll.HOADON_Select();
        }



        private void Btsuahd_Click(object sender, EventArgs e)
        {
            hdbll.HOADON_Update(tbmahoadon.Text, tbmaban.Text, tbngaylaphd.Text, tbghichu.Text);
            Bthienthihd_Click(sender, e);
        }

        private void Btxoahd_Click(object sender, EventArgs e)
        {
            hdbll.HOADON_Delete(tbmahoadon.Text);
            Bthienthihd_Click(sender, e);
            
        }

        private void DtgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbmahoadon.Text = dtgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbmaban.Text = dtgvHD.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbngaylaphd.Text = dtgvHD.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbghichu.Text = dtgvHD.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (tbghichu.Text == "Chua thanh toán")
            {
                tbghichu.Text = "0";
            }
            else
                tbghichu.Text = "1";
        }

        private void Bttimkiemhd_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource = hdbll.HOADON_Select_where(tbtimkiemhd.Text);
        }

        private void QLHOADON_Load(object sender, EventArgs e)
        {
            //tbghichu.Enabled=false;
        }

        private void Btquaylai_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            this.Hide();
            mhc.ShowDialog();
        }

        private void Bthtcthd_Click(object sender, EventArgs e)
        {
            dtgvHD.DataSource= hdbll.HOADON_hienthicthd(tbmaban.Text,tbmahoadon.Text);
        }
    }
}
