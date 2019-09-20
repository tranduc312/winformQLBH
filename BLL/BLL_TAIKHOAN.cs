using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_TAIKHOAN
    {
        DAL_TAIKHOAN tkdal = new DAL_TAIKHOAN();
        //phương thức này gọi phương thức sv_select() ở lớp TAIKHOAN_DAL (tầng DAL)
        public DataTable TAIKHOAN_Select()
        {
            return tkdal.TAIKHOAN_select();
        }
        
        public DataTable TAIKHOAN_Select_where(string taikhoan)
        {
            return tkdal.TAIKHOAN_select_where(taikhoan);
        }
        public DataTable TAIKHOAN_DangNhap(string taikhoan, string matkhau)
        {
            return tkdal.TAIKHOAN_DangNhap(taikhoan, matkhau);
        }
        //phương thức này gọi phương thức sv_insert() ở lớp TAIKHOAN_DAL (tầng DAL)
        public int TAIKHOAN_Insert(string taikhoan, string matkhau, string loaitk)
        {
            return tkdal.TAIKHOAN_insert(taikhoan, matkhau, loaitk);
        }

        //phương thức này gọi phương thức sv_update() ở lớp TAIKHOAN_DAL (tầng DAL)
        public int TAIKHOAN_Update(string taikhoan,string matkhau, string loaitk)
        {
            return tkdal.TAIKHOAN_update(taikhoan,matkhau, loaitk);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp TAIKHOAN_DAL (tầng DAL)
        public int TAIKHOAN_Delete(string taikhoan)
        {
            return tkdal.TAIKHOAN_delete(taikhoan);
        }
    }
}
