using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DAL_BAN
    {
        Thaotac_CSDL thaotac = new Thaotac_CSDL();
        //khai báo 2 mảng để truyền tên tham số và giá trị tham số vào Stored Procedures
        string[] name = { };
        object[] value = { };
        //phương thức này gọi phương thức SQL_Laydulieu ở lớp ThaoTac_CoSoDuLieu để thực hiện lấy dữ liệu
        public DataTable BAN_select()
        {
            //thaotac.KetnoiCSDL();
            return thaotac.SQL_Laydulieu("BAN_Select");
        }
        public DataTable BAN_select_where(string maban)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = maban;

            return thaotac.SQL_Laydulieu_CoDK("BAN_Select_where", name, value, 1);
        }

        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện insert
        public int BAN_insert(string maban, string tenban, string ghichu)
        {
            //thaotac.KetnoiCSDL();
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBan"; value[0] = maban;//@,... là các tham số phải giống với tham số khai báo ở Stores Procedures trong CSDL
            name[1] = "@TenBan"; value[1] = tenban;
            name[2] = "@GhiChu"; value[2] = ghichu;

            return thaotac.SQL_Thuchien("BAN_Insert", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện update
        public int BAN_update(string maban,string tenban, string ghichu)

        {
            name = new string[3];
            value = new object[3];
            name[0] = "@MaBan"; value[0] = maban;
            name[1] = "@TenBan"; value[1] = tenban;
            name[2] = "@GhiChu"; value[2] = ghichu;
            return thaotac.SQL_Thuchien("BAN_Update", name, value, 3);
        }
        //phương thức này gọi phương thức SQL_Thuchien ở lớp ThaoTac_CoSoDuLieu để thực hiện delete
        public int BAN_delete(string maban)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@MaBan"; value[0] = maban;

            return thaotac.SQL_Thuchien("BAN_Delete", name, value, 1);
        }
    }
}
