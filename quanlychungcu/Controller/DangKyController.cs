using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class DangKyController
    {
        public DangKyController()
        {

        }
        public bool startDangKy(string username, string password, string roleuser)
        {
            string querystring = "insert into taikhoan values ( @username , @password , @roleuser )";
            object[] para = { username, password, roleuser };
            try
            {
                int status = DataProvider.Instance.ExecuteNonQuery(querystring, para);
                if (status == 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
            
        }
    }
}
