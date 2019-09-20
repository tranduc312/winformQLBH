using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_HOADON
    {
        
        DAL_HOADON hddal = new DAL_HOADON();
        //phương thức này gọi phương thức sv_select() ở lớp HOADON_DAL (tầng DAL)
        public DataTable HOADON_Select()
        {
            return hddal.HOADON_select();
        }
        public DataTable HOADON_hienthi(string maban)
        {
            return hddal.HOADON_hienthi(maban);
        }

        public DataTable HOADON_hienthicthd(string maban,string mahd)
        {
            return hddal.HOADON_hienthicthd(maban, mahd);
        }

        public DataTable HOADON_Select_where(string mahd)
        {
            return hddal.HOADON_select_where(mahd);
        }
        public DataTable HOADON_kiemtraban(string maban)
        {
            return hddal.HOADON_kiemtraban(maban);
        }
        public int HOADON_chuyenban(string maban, string mahd)
        {
            return hddal.HOADON_chuyenban(maban, mahd);
        }
       public int SET_bantrong(string maban)
        {
            return hddal.SET_bantrong(maban);
        }
        public int HOADON_SETBANVAO(string maban)
        {
            return hddal.HOADON_SETBANVAO(maban);
        }
      
        public int HOADON_SETBANRA(string maban,string mahd)
        {
            return hddal.HOADON_SETBANRA(maban,mahd);
        }
        //phương thức này gọi phương thức sv_insert() ở lớp HOADON_DAL (tầng DAL)
        public int HOADON_Insert(string mahd, string maban, string ngaylaphd, string ghichu)
        {
            return hddal.HOADON_insert(mahd,  maban, ngaylaphd, ghichu);
        }

        //phương thức này gọi phương thức sv_update() ở lớp HOADON_DAL (tầng DAL)
        public int HOADON_Update(string mahd, string maban, string ngaylaphd, string ghichu)
        {
            return hddal.HOADON_update(mahd, maban, ngaylaphd, ghichu);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp HOADON_DAL (tầng DAL)
        public int HOADON_Delete(string mahd)
        {
            return hddal.HOADON_delete(mahd);
        }
    }
}
