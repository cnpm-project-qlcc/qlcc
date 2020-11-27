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
    public partial class TrangChu : Form
    {
        private TaiKhoanController taiKhoanController;
        private string username;
        public TrangChu()
        {
            InitializeComponent();
        }
        public TrangChu(string username)
        {
            InitializeComponent();
            this.username = username;
            label_xinchao.Text = "Xin chào " + username;
            initController();
      
        }
        private void initController()
        {
            taiKhoanController = new TaiKhoanController();
        }
        private string getRoleUser() //lấy quyền của người dùng
        {
            return taiKhoanController.getRoleUser(this.username);
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void lb_dangxuat_Click(object sender, EventArgs e)
        {
            DangNhap dangnhap = new DangNhap();
            this.Hide();
            dangnhap.ShowDialog();
            this.Close();
        }

        private void btn_dangkytaikhoan_Click(object sender, EventArgs e) //chỉ có admin được đăng ký
        {
            //kiểm tra quyền trước khi thực hiện
            string currentRoleuser = getRoleUser();
            if (currentRoleuser != "admin")
            {
                showError("Bạn không đủ quyền hạn để thực hiện chức năng đăng ký tài khoản, vui lòng liên hệ với Admin hệ thống");
            }
            else
            {
                DangKy dangky = new DangKy();
                dangky.ShowDialog();
            }
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void btn_quanlycanho_Click(object sender, EventArgs e)
        {
            string roleuser = getRoleUser();
            if(roleuser!="admin" && roleuser != "ch")
            {
                showError("Bạn không đủ quyền hạn để sử dụng chức năng này, vui lòng chọn chức năng khác");
            }
            else
            {
                QuanLyCanHo quanlycanho = new QuanLyCanHo();
                quanlycanho.ShowDialog();
            }
        }

        private void btn_quanlydancu_Click(object sender, EventArgs e)
        {
            string roleuser = getRoleUser();
            if (roleuser != "admin" && roleuser != "dc")
            {
                showError("Bạn không đủ quyền hạn để sử dụng chức năng này, vui lòng chọn chức năng khác");
            }
            else
            {
                QuanLyDanCu quanlydancu = new QuanLyDanCu();
                quanlydancu.ShowDialog();
            }
        }

        private void btn_quanlydichvu_Click(object sender, EventArgs e)
        {
            string roleuser = getRoleUser();
            if(roleuser!="admin" && roleuser != "dv")
            {
                showError("Bạn không đủ quyền hạn để sử dụng chức năng này, vui lòng chọn chức năng khác");
            }
            else
            {
                QuanLyDichVu quanLyDichVu = new QuanLyDichVu();
                quanLyDichVu.ShowDialog();
            }
        }

        private void btn_quanlycongno_Click(object sender, EventArgs e)
        {
            string roleuser = getRoleUser();
            if (roleuser != "admin" && roleuser != "cn")
            {
                showError("Bạn không đủ quyền hạn để sử dụng chức năng này, vui lòng chọn chức năng khác");
            }
            else
            {
                QuanLyCongNo quanlycongno = new QuanLyCongNo(username);
                quanlycongno.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(username);
            doiMatKhau.ShowDialog();
        }
    }
}
