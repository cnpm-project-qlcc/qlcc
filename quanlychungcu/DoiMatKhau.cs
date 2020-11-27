using quanlychungcu.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlychungcu
{
    public partial class DoiMatKhau : Form
    {
        private string username;
        private TaiKhoanController taiKhoanController;
        public DoiMatKhau(string username)
        {
            InitializeComponent();
            this.username=username;
            taiKhoanController = new TaiKhoanController();

        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            string password = txt_password.Text;
            string newpassword = txt_newpassword.Text;
            string confirmnewpassword = txt_confirmnewpassword.Text;
            if(password.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập mật khẩu hiện tại");
                txt_password.Focus();
                return;
            }
            else if (password.Trim(' ').Length < 6 )
            {
                showError("Độ dài mật khẩu phải có ít nhất 6 kí tự");
                txt_password.Focus();
                return;
            }
            else if(newpassword.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập mật khẩu mới");
                txt_newpassword.Focus();
                return;
            }
            else if (newpassword.Trim(' ').Length < 6)
            {
                showError("Độ dài mật khẩu phải có ít nhất 6 kí tự");
                txt_newpassword.Focus();
                return;
            }
            else if (newpassword != confirmnewpassword)
            {
                showError("Mật khẩu mới và mật khẩu xác nhận phải giống nhau");
                txt_newpassword.Focus();
                return;
            }
            bool status = taiKhoanController.startDoiMatKhau(this.username, password, newpassword);
            if (status == true)
            {
                showError("Thay đổi mật khẩu thành công");
                txt_confirmnewpassword.Clear();
                txt_password.Clear();
                txt_newpassword.Clear();
            }
            else
            {
                showError("Mật khẩu hiện tại không đúng, vui lòng thử lại");
            }

            
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }
    }
}
