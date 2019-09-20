using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_HOADON
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable HOADON_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("HOADON_Select");
        }
        public DataTable HOADON_hienthi(string maban)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = maban;
            return thaotac.SQL_Laydulieu_CoDK("HOADON_hienthi", name, value, 1);
        }
        public DataTable HOADON_hienthicthd(string maban,string mahd)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = maban;
            name[1] = "@MaHD"; value[1] = mahd;

            return thaotac.SQL_Laydulieu_CoDK("HOADON_hienthicthd", name, value, 2);
        }

        public DataTable HOADON_select_where(string mahd)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD";value[0] = mahd;
            return thaotac.SQL_Laydulieu_CoDK("HOADON_Select_where", name, value, 1);
        }
        public DataTable HOADON_kiemtraban(string maban)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = maban;

            return thaotac.SQL_Laydulieu_CoDK("HOADON_kiemtraban", name, value, 1);
        }
        public int HOADON_chuyenban(string maban,string mahd)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan";value[0] = maban;
            name[1] = "@MaHD";value[1] = mahd;

            return thaotac.SQL_Thuchien("HOADON_chuyenban", name, value, 2);
        }
        public int SET_bantrong(string maban)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan";value[0] = maban;

            return thaotac.SQL_Thuchien("SET_bantrong", name, value, 1);
        }
        public int HOADON_SETBANVAO( string maban)

        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = maban;
            //@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            

            return thaotac.SQL_Thuchien("SET_BAN_VAO", name, value, 1);
        }
       
        public int HOADON_SETBANRA(string maban,string mahd)

        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaBan"; value[0] = maban;
            name[1] = "@MaHD"; value[1] = mahd;
            //@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL


            return thaotac.SQL_Thuchien("SET_BAN_RA", name, value, 2);
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int HOADON_insert(string mahd, string maban, string ngaylaphd, string ghichu)
        {
            //thaotac.KetnoiCSDL();
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = mahd;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@MaBan"; value[1] = maban;
            name[2] = "@NgayLapHD"; value[2] = ngaylaphd;
            name[3] = "@GhiChu"; value[3] = ghichu;

            return thaotac.SQL_Thuchien("HOADON_Insert", name, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int HOADON_update(string mahd, string maban, string ngaylaphd, string ghichu)

        {
            name = new string[4];
            value = new object[4];
            name[0] = "@MaHD"; value[0] = mahd;
            name[1] = "@MaBan"; value[1] = maban;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[2] = "@NgayLapHD"; value[2] = ngaylaphd;
            name[3] = "@GhiChu"; value[3] = ghichu;

            return thaotac.SQL_Thuchien("HOADON_Update", name, value, 4);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int HOADON_delete(string mahd)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHD"; value[0] = mahd;

            return thaotac.SQL_Thuchien("HOADON_Delete", name, value, 1);
        }
    }
}
