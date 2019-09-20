using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_HANGHOA
    {
        DAL_HANGHOA hhdal = new DAL_HANGHOA();
        //phương thức này gọi phương thức sv_select() ở lớp HANGHOA_DAL (tầng DAL)
        public DataTable HANGHOA_Select()
        {
            return hhdal.HANGHOA_select();
        }
        public DataTable HANGHOA_select_where(string mahang)
        {
            return hhdal.HANGHOA_select_where(mahang);
        }
        public DataTable HANGHOA_select_where3(string maloaihang)
        {
            return hhdal.HANGHOA_select_where3(maloaihang);
        }
        public DataTable HANGHOA_select_where4(string mahang)
        {
            return hhdal.HANGHOA_select_where4(mahang);
        }
        //phương thức này gọi phương thức sv_insert() ở lớp HANGHOA_DAL (tầng DAL)
        public int HANGHOA_Insert(string mahang, string tenhang, string dvt, string dongia, string maloaihang)
        {
            return hhdal.HANGHOA_insert(mahang, tenhang, dvt, dongia, maloaihang);
        }

        //phương thức này gọi phương thức sv_update() ở lớp HANGHOA_DAL (tầng DAL)
        public int HANGHOA_Update(string mahang, string tenhang, string dvt, string dongia)
        {
            return hhdal.HANGHOA_update(mahang,tenhang, dvt, dongia);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp HANGHOA_DAL (tầng DAL)
        public int HANGHOA_Delete(string mahang)
        {
            return hhdal.HANGHOA_delete(mahang);
        }
    }
}
