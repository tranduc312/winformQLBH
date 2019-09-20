using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_CTHD
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable CTHD_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("CTHD_Select");
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int CTHD_insert(string mahanghoa, string mahoadon, string sl)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];

            name[0] = "@MaHangHoa"; value[0] = mahanghoa;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@MaHoaDon"; value[1] = mahoadon;
            name[2] = "@SL"; value[2] = sl;
            return thaotac.SQL_Thuchien("CTHD_Insert", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int CTHD_update(string mahanghoa,string mahoadon,string sl)
        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaHangHoa"; value[0] = mahanghoa;
            name[1] = "@MaHoaDon"; value[1] = mahoadon;
            name[2] = "@SL"; value[2] = sl;//@HoTen,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            return thaotac.SQL_Thuchien("CTHD_Update", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int CTHD_delete(string mahanghoa, string mahoadon)
        {
            name = new string[2];
            value = new object[2];
            name[0] = "@MaHangHoa"; value[0] = mahanghoa;
            name[1] = "@MaHoaDon"; value[1] = mahoadon;
            return thaotac.SQL_Thuchien("CTHD_Delete", name, value, 2);
        }

    }
}
