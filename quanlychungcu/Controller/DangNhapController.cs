using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class DangNhapController
    {
         public DangNhapController()
        {

        }
        public bool startLogin(string username, string password)
        {
            string querystring = "select count(username) from taikhoan where username = @username and passwordname = @password ";
            object[] para = { username, password };
            int exists = (int)DataProvider.Instance.ExecuteScalar(querystring, para);
            if(exists == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        
    }

}
