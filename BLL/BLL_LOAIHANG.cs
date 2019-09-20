using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_LOAIHANG
    {
        DAL_LOAIHANG lhdal = new DAL_LOAIHANG();
        //phương thức này gọi phương thức sv_select() ở lớp LOAIHANG_DAL (tầng DAL)
        public DataTable LOAIHANG_Select()
        {
            return lhdal.LOAIHANG_select();
        }
        public DataTable LOAIHANG_Select_where(string maloaihang)
        {
            return lhdal.LOAIHANG_Select_where(maloaihang);
        }
        //phương thức này gọi phương thức sv_insert() ở lớp LOAIHANG_DAL (tầng DAL)
        public int LOAIHANG_Insert(string maloaihang, string tenloaihang, string ghichu)
        {
            return lhdal.LOAIHANG_insert(maloaihang, tenloaihang, ghichu);
        }
        
        //phương thức này gọi phương thức sv_update() ở lớp LOAIHANG_DAL (tầng DAL)
        public int LOAIHANG_Update(string maloaihang,string tenloaihang, string ghichu)
        {
            return lhdal.LOAIHANG_update(maloaihang,tenloaihang, ghichu);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp LOAIHANG_DAL (tầng DAL)
        public int LOAIHANG_Delete(string maloaihang)
        {
            return lhdal.LOAIHANG_delete(maloaihang);
        }
    }
}
