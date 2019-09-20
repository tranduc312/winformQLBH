using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_HANGHOA
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable HANGHOA_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("HANGHOA_Select");
        }
        public DataTable HANGHOA_select_where(string mahang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang";value[0] = mahang;
            return thaotac.SQL_Laydulieu_CoDK("HANGHOA_Select_where", name, value, 1);

        }
        public DataTable HANGHOA_select_where3(string maloaihang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaLoaiHang"; value[0] = maloaihang;
            return thaotac.SQL_Laydulieu_CoDK("HANGHOA_Select_where3", name, value, 1);

        }
        public DataTable HANGHOA_select_where4(string mahang)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaHang"; value[0] = mahang;
            return thaotac.SQL_Laydulieu_CoDK("HANGHOA_Select_where4", name, value, 1);

        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int HANGHOA_insert(string mahang, string tenhang, string dvt, string dongia, string maloaihang)
        {
            //thaotac.KetnoiCSDL();
            name = new string[5];
            value = new object[5];
            name[0] = "@MaHang"; value[0] = mahang;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenHang"; value[1] = tenhang;
            name[2] = "@DVT"; value[2] = dvt;
            name[3] = "@DonGia"; value[3] = dongia;
            name[4] = "@MaLoaiHang"; value[4] = maloaihang;
            return thaotac.SQL_Thuchien("HANGHOA_Insert", name, value, 5);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int HANGHOA_update(string mahang,string tenhang, string dvt, string dongia)
        
            {
                name = new string[4];
                value = new object[5];
                name[0] = "@MaHang"; value[0] = mahang;
                name[1] = "@TenHang"; value[1] = tenhang;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
                name[2] = "@DVT"; value[2] = dvt;
                name[3] = "@DonGia"; value[3] = dongia;
                return thaotac.SQL_Thuchien("HANGHOA_Update", name, value, 4);
            }
            //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public  int HANGHOA_delete(string mahang)
            {
                name = new string[1];
                value = new object[1];
                name[0] = "@MaHang"; value[0] = mahang;

                return thaotac.SQL_Thuchien("HANGHOA_Delete", name, value, 1);
            }
        
    }
}
