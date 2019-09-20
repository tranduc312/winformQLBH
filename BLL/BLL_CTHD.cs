using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_CTHD
    {
        DAL_CTHD cthddal = new DAL_CTHD();
        //phương thức này gọi phương thức sv_select() ở lớp CTHD_DAL (tầng DAL)
        public DataTable CTHD_Select()
        {
            return cthddal.CTHD_select();
        }

        //phương thức này gọi phương thức sv_insert() ở lớp CTHD_DAL (tầng DAL)
        public int CTHD_Insert(string mahanghoa, string mahoadon, string sl)
        {
            return cthddal.CTHD_insert(mahanghoa, mahoadon, sl);
        }

        //phương thức này gọi phương thức sv_update() ở lớp CTHD_DAL (tầng DAL)
        public int CTHD_Update( string mahanghoa,string mahoadon,string sl)
        {
            return cthddal.CTHD_update(mahanghoa,mahoadon, sl);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp CTHD_DAL (tầng DAL)
        public int CTHD_Delete(string mahanghoa, string mahoadon)
        {
            return cthddal.CTHD_delete(mahanghoa, mahoadon);
        }
    }
}
