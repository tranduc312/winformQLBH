using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_LOAIHANG
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable LOAIHANG_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("LOAIHANG_Select");
        }
        public DataTable LOAIHANG_Select_where(string maloaihang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang";value[0] = maloaihang;

            return thaotac.SQL_Laydulieu_CoDK("LOAIHANG_Select_where", name, value, 1);
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int LOAIHANG_insert(string maloaihang, string tenloaihang, string ghichu)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = maloaihang;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenLoaiHang"; value[1] = tenloaihang;
            name[2] = "@GhiChu"; value[2] = ghichu;

            return thaotac.SQL_Thuchien("LOAIHANG_Insert", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int LOAIHANG_update(string maloaihang,string tenloaihang, string ghichu)

        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaLoaiHang"; value[0] = maloaihang;
            name[1] = "@TenLoaiHang"; value[1] = tenloaihang;
            name[2] = "@GhiChu"; value[2] = ghichu;
            return thaotac.SQL_Thuchien("LOAIHANG_Update", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int LOAIHANG_delete(string maloaihang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = maloaihang;

            return thaotac.SQL_Thuchien("LOAIHANG_Delete", name, value, 1);
        }
    }
}
