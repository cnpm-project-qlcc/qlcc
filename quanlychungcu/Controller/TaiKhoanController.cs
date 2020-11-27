using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class TaiKhoanController
    {
        public TaiKhoanController()
        {

        }
        private bool startExecuteNonquery(string querystring, object[] para) //hàm thực hiện chạy câu lệnh executeNonquery
        {
            try
            {
                int status = DataProvider.Instance.ExecuteNonQuery(querystring, para);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
        public string getRoleUser(string username)
        {
            string querystring = " select roleuser from taikhoan where username = @username ";
            object[] para = { username };
            return DataProvider.Instance.ExecuteScalar(querystring, para).ToString();
        }
        public bool startDoiMatKhau(string username,string oldpassword, string newpassword)
        {
            string querystring = "update taikhoan set passwordname = @newpassword where passwordname = @oldpassword and username = @username ";
            object[] para = { newpassword, oldpassword, username };
            int status= DataProvider.Instance.ExecuteNonQuery(querystring, para);
            if (status == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
