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
    public partial class DangNhap : Form
    {
        private DangNhapController dangNhapController;
        public DangNhap()
        {
            InitializeComponent();
            initController();
        }
        private void initController()
        {
            dangNhapController = new DangNhapController();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
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
            else
            {
               Boolean exists= dangNhapController.startLogin(username, password);
                if(exists == true)
                {
                    toTrangChu(username);
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại, vui lòng nhập lại");
                }
            }
        }
        private void toTrangChu(string username) //tới trang chủ nếu đăng nhập thành công
        {
            TrangChu trangchu = new TrangChu(username);
            this.Hide();
            trangchu.ShowDialog();
            this.Close();
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }
    }
}
