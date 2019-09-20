using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_TAIKHOAN
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable TAIKHOAN_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("TAIKHOAN_Select");
        }

        public DataTable TAIKHOAN_select_where(string taikhoan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TaiKhoan";value[0] = taikhoan;
            return thaotac.SQL_Laydulieu_CoDK("TAIKHOAN_Select_where", name, value, 1);
        }
       public DataTable TAIKHOAN_DangNhap(string taikhoan, string matkhau)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@TaiKhoan"; value[0] = taikhoan;
            name[0] = "@MatKhau"; value[0] = matkhau;

            return thaotac.SQL_Laydulieu_CoDK("TAIKHOAN_DangNhap", name, value, 2);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int TAIKHOAN_insert(string taikhoan, string matkhau, string loaitk)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@TaiKhoan"; value[0] = taikhoan;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@MatKhau"; value[1] = matkhau;
            name[2] = "@LoaiTK"; value[2] = loaitk;

            return thaotac.SQL_Thuchien("TAIKHOAN_Insert", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int TAIKHOAN_update(string taikhoan,string matkhau, string loaitk)

        {
            name = new string[3];
            value = new object[3];
            name[0] = "@TaiKhoan"; value[0] = taikhoan;
            name[1] = "@MatKhau"; value[1] = matkhau;
            name[2] = "@LoaiTK"; value[2] = loaitk;
            return thaotac.SQL_Thuchien("TAIKHOAN_Update", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int TAIKHOAN_delete(string taikhoan)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@TaiKhoan"; value[0] = taikhoan;

            return thaotac.SQL_Thuchien("TAIKHOAN_Delete", name, value, 1);
        }
    }
}
