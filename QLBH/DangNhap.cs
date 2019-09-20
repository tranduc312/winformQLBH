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
using BLL;


namespace QLBH
{
    public partial class DangNhap : Form
    {
        BLL_TAIKHOAN tkbll = new BLL_TAIKHOAN();
        public DangNhap()
        {
            InitializeComponent();
        }

     

        private void Btdangnhap_Click(object sender, EventArgs e)
        {
           
            SqlConnection cn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLBHmohinh3lop;Integrated Security=True");
            string sql = "select * from TAIKHOAN where taikhoan='" + tbtaikhoan.Text + "' and matkhau='" + tbmatkhau.Text + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {


                ManHinhChinh mhc = new ManHinhChinh();
                this.Hide();
                mhc.ShowDialog();
                //this.Show();
                
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }


        }


        private void Btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có muốn thoát",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                Dispose();
            }
        }

        private void Bthienthimk_Click(object sender, EventArgs e)
        {
            tbmatkhau.UseSystemPasswordChar = false;
        }
    }
}
