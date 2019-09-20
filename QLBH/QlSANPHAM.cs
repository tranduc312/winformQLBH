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
    public partial class QlSANPHAM : Form
    {
        BLL_HANGHOA spbll = new BLL_HANGHOA();
        public QlSANPHAM()
        {
            InitializeComponent();
        }

        private void Bthienthisp_Click(object sender, EventArgs e)
        {
            dtgvSP.DataSource = spbll.HANGHOA_Select();
        }
        
        //them sp
        private void Button3_Click(object sender, EventArgs e)
        {
            spbll.HANGHOA_Insert(tbmahang.Text, tbtenhang.Text, tbdvt.Text, tbdongia.Text, tbmaloaihang.Text);
            Bthienthisp_Click(sender, e);
        }

        private void Btsuasp_Click(object sender, EventArgs e)
        {
            spbll.HANGHOA_Update(tbmahang.Text,tbtenhang.Text, tbdvt.Text, tbdongia.Text);
            Bthienthisp_Click(sender, e);
        }

        private void Btxoasp_Click(object sender, EventArgs e)
        {
            spbll.HANGHOA_Delete(tbmahang.Text);
            Bthienthisp_Click(sender, e);
        }

        

        private void DtgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbmahang.Text = dtgvSP.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbtenhang.Text = dtgvSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbdvt.Text = dtgvSP.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbdongia.Text = dtgvSP.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbmaloaihang.Text = dtgvSP.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Bttimkiemsp_Click(object sender, EventArgs e)
        {
            dtgvSP.DataSource = spbll.HANGHOA_select_where(tbtimkiemsp.Text);
            
        }

        private void Btquaylai_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            this.Hide();
            mhc.ShowDialog();
        }
    }
}
