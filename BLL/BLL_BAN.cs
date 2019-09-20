using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_BAN
    {
        DAL_BAN bandal = new DAL_BAN();
        //phương thức này gọi phương thức sv_select() ở lớp BAN_DAL (tầng DAL)
        public DataTable BAN_Select()
        {
            return bandal.BAN_select();
        }
        public DataTable BAN_Select_where(string maban)
        {
            return bandal.BAN_select_where(maban);
        }
        //phương thức này gọi phương thức sv_insert() ở lớp BAN_DAL (tầng DAL)
        public int BAN_Insert(string maban, string tenban, string ghichu)
        {
            return bandal.BAN_insert(maban, tenban, ghichu);
        }

        //phương thức này gọi phương thức sv_update() ở lớp BAN_DAL (tầng DAL)
        public int BAN_Update(string maban,string tenban, string ghichu)
        {
            return bandal.BAN_update(maban,tenban, ghichu);
        }

        //phương thức này gọi phương thức sv_delete() ở lớp BAN_DAL (tầng DAL)
        public int BAN_Delete(string maban)
        {
            return bandal.BAN_delete(maban);
        }

    }
}
