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
    public partial class DangKy : Form
    {
        DangKyController dangKyController;
        public DangKy()
        {
            InitializeComponent();
            this.dangKyController = new DangKyController();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            string confirmpassword = txt_confirmpassword.Text;
            if (username.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên tài khoản");
                txt_username.Focus();
            }
            else if (password.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập mật khẩu");
                txt_password.Focus();
            }
            else if (password.Trim(' ').Length < 6)
            {
                showError("Mật khẩu phải có ít nhất 6 kí tự, vui lòng nhập lại");
                txt_password.Focus();
            }
            else if (password != confirmpassword)
            {
                showError("Mật khẩu và mật khẩu xác nhận phải giống nhau, vui lòng nhập lại");
                txt_password.Focus();
            }
            else
            {
                string roleuser = "admin";
                RadioButton[] radiobuttonarray = { rdbtn_admin, rdbtn_ch, rdbtn_cn, rdbtn_dc, rdbtn_dv };
                foreach(RadioButton rdbtn in radiobuttonarray)
                {
                    if (rdbtn.Checked == true)
                    {
                        roleuser = rdbtn.Text;
                    }
                }
                bool status = dangKyController.startDangKy(username, password, roleuser);
                if(status == true)
                {
                    showError("Đăng ký tài khoản thành công");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_confirmpassword.Clear();
                }
                else
                {
                    showError("Tài khoản bạn muốn đăng ký đã tồn tại, vui lòng thử lại");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_confirmpassword.Clear();
                    txt_username.Focus();
                }
            }
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }
    }
}
