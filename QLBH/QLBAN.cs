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
using System.Data.SqlClient;

namespace QLBH
{
    public partial class QLBAN : Form
    {
        BLL_BAN banbll = new BLL_BAN();
        BLL_HOADON hdbll = new BLL_HOADON();
        BLL_HANGHOA hhbll = new BLL_HANGHOA();
        BLL_CTHD cthdbll = new BLL_CTHD();
        BLL_LOAIHANG lhbll = new BLL_LOAIHANG();
       
        public QLBAN()
        {
            InitializeComponent();
        }


        private void Btthanhtoan_Click(object sender, EventArgs e)
        {
            hdbll.HOADON_SETBANRA(cbmaban.SelectedValue.ToString(), tbmahd.Text);
            Cbmaban_SelectedIndexChanged(sender, e);
            MessageBox.Show("Thanh toán thành công");
            //INHOADON inhd = new INHOADON();
            //this.Hide();
            //inhd.ShowDialog();
        }

        private void Btthemhd_Click(object sender, EventArgs e)
        {
           
            hdbll.HOADON_Insert(tbmahd.Text,cbmaban.SelectedValue.ToString(), dtpngaylaphd.Value.ToString(),tbghichu.Text);
            hdbll.HOADON_SETBANVAO(cbmaban.SelectedValue.ToString());
            MessageBox.Show("Thêm thành công");
        }

        private void Btthemcthd_Click(object sender, EventArgs e)
        {
            cthdbll.CTHD_Insert(cbtenhang.SelectedValue.ToString(), tbmacthd.Text, numsl.Value.ToString());
            MessageBox.Show("Thêm thành công");
            Cbmaban_SelectedIndexChanged(sender, e);
        }

        private void Cbmaban_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtgvhienthihd.DataSource = hdbll.HOADON_hienthi(cbmaban.SelectedValue.ToString());

        }

        private void QLBAN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHmohinh3lopDataSet.HANGHOA' table. You can move, or remove it, as needed.
            this.hANGHOATableAdapter.Fill(this.qLBHmohinh3lopDataSet.HANGHOA);
            //cbmahang
            cbmaban.DataSource = banbll.BAN_Select();
            cbmaban.DisplayMember = "TenBan";
            cbmaban.ValueMember = "MaBan";
            //binding mahd
            Binding bd = new Binding("text", tbmahd, "text");
            tbmacthd.DataBindings.Add(bd);
            //cbloaihang
            cbloaihang.DataSource = lhbll.LOAIHANG_Select();
            cbloaihang.ValueMember = "MaLoaiHang";
            cbloaihang.DisplayMember = "TenLoaiHang";
            //cbchuyenban
            cbchuyenban.DataSource = banbll.BAN_Select();
            cbchuyenban.DisplayMember = "TenBan";
            cbchuyenban.ValueMember = "MaBan";
            
        }

        private void Dtgvhienthihd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cbmaban_SelectedIndexChanged(sender, e);
            tbmahd.Text = dtgvhienthihd.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Cbtenhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = hhbll.HANGHOA_select_where4(cbtenhang.SelectedValue.ToString());
            tbdongia.Text = dt.Rows[0][3].ToString();

        }
        private void Cbloaihang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtenhang.DataSource = hhbll.HANGHOA_select_where3(cbloaihang.SelectedValue.ToString());
            cbtenhang.DisplayMember = "TenHang";
            cbtenhang.ValueMember = "MaHang";

        }

        private void Cbchuyenban_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgvhienthihd.DataSource = hdbll.HOADON_hienthi(cbmaban.SelectedValue.ToString());


        }

        private void Btchuyenban_Click(object sender, EventArgs e)
        {
            hdbll.HOADON_chuyenban(cbchuyenban.SelectedValue.ToString(), tbmahd.Text);
            hdbll.SET_bantrong(cbmaban.SelectedValue.ToString());
            hdbll.HOADON_chuyenban(cbchuyenban.SelectedValue.ToString(), tbmahd.Text);
            MessageBox.Show("Chuyển bàn thành công");
            Cbmaban_SelectedIndexChanged(sender, e);
        }
        private void Cbchuyenban_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt = hdbll.HOADON_kiemtraban(cbchuyenban.SelectedValue.ToString());
            tbketquaktban.Text = dt.Rows[0][0].ToString();
            if (tbketquaktban.Text == "Ban trong")
            {
                MessageBox.Show("Bàn trống");
            }
            else
                MessageBox.Show("Bàn đã có người, vui lòng chọn bàn khác");
        }

        private void Btquaylai_Click(object sender, EventArgs e)
        {
            ManHinhChinh mhc = new ManHinhChinh();
            this.Hide();
            mhc.ShowDialog();
        }
    }


}
