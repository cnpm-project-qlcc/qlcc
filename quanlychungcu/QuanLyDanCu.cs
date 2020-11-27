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
    public partial class QuanLyDanCu : Form
    {
        QuanLyDanCuController quanLyDanCuController;

        public QuanLyDanCu()
        {
            InitializeComponent();
            Blockform();
            combobox_search.SelectedIndex = 0;
            quanLyDanCuController = new QuanLyDanCuController();
            loadListDanCu();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public void loadListDanCu()
        {
            datagridview_quanlydancu.DataSource = quanLyDanCuController.getListDanCu();
        }

        private void btn_themdancu_Click(object sender, EventArgs e)
        {
            string hovatenlot = txt_hovatenlotnew.Text;
            string ten = txt_tennew.Text;
            string ngaysinh= datepicker_ngaysinhnew.Value.ToString("dd/MM/yyyy");
            int gioitinh = 1;
            if (rdbtn_nunew.Checked == true)
            {
                gioitinh = 0;
            }
            string cmnd = txt_cmndnew.Text;
            string sdt = txt_sdtnew.Text;
            string ngaychuyenvao = datepicker_ngaychuyenvaonew.Value.ToString("dd/MM/yyyy");
            string macanho =  txt_macanhonew.Text;
            if(hovatenlot.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập họ và tên lót");
                txt_hovatenlotnew.Focus();
                return;
            }
            else if(ten.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên");
                txt_ten.Focus();
                return;
            }
            else if (macanho.Trim().Length == 0)
            {
                showError("Vui lòng nhập mã căn hộ");
                txt_ten.Focus();
                return;
            }
            int macanhonum = Int16.Parse(macanho);
            object[] thongtindancu = { hovatenlot, ten, ngaysinh, gioitinh, cmnd, sdt, ngaychuyenvao, macanhonum };
            bool status = quanLyDanCuController.startThemDanCu(thongtindancu);
            if(status == true)
            {
                showError("Thêm dân cư thành công");
                txt_hovatenlotnew.Clear();
                txt_tennew.Clear();
                datepicker_ngaychuyenvaonew.Value = DateTime.Now;
                rdbtn_nam.Checked = true;
                txt_sdtnew.Clear();
                txt_macanhonew.Clear();
                txt_cmndnew.Clear();
                datepicker_ngaychuyenvaonew.Value = DateTime.Now;
                loadListDanCu();
            }
            else
            {
                showError("Thêm dân cư thất bại, kiểm tra lại mã căn hộ");

            }


        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }
        private void unBlockform()
        {
            btn_lammoi.Enabled = true;
            btn_suathongtindancu.Enabled = true;
            btn_xoadancu.Enabled = true;
        }
        private void Blockform()
        {
            btn_lammoi.Enabled = false;
            btn_suathongtindancu.Enabled = false;
            btn_xoadancu.Enabled = false;
        }

        private void datagridview_quanlydancu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewRow rowSelected = datagridview_quanlydancu.Rows[e.RowIndex]; //lấy ra row của DataGridView được chọn
                txt_madancu.Text= rowSelected.Cells[0].Value.ToString();
                txt_hovatenlot.Text = rowSelected.Cells[1].Value.ToString();
                txt_ten.Text = rowSelected.Cells[2].Value.ToString();
              
                string ngaysinh= rowSelected.Cells[3].Value.ToString();
                datepicker_ngaysinh.Value = DateTime.ParseExact(ngaysinh, "dd/MM/yyyy", null);
                int gioitinh = (int)rowSelected.Cells[4].Value;
                rdbtn_nam.Checked = true;
                if (gioitinh == 0)
                {
                    rdbtn_nu.Checked = true;
                }
                txt_cmnd.Text= rowSelected.Cells[5].Value.ToString();
                txt_sdt.Text= rowSelected.Cells[6].Value.ToString();
                string ngaychuyenvao= rowSelected.Cells[7].Value.ToString();
                datepicker_ngaychuyenvao.Value=DateTime.ParseExact(ngaychuyenvao, "dd/MM/yyyy", null);
                txt_macanho.Text= rowSelected.Cells[8].Value.ToString();
                //mở form cho phép sửa, xóa, làm mới
                unBlockform();

            }
            catch (Exception error)
            {
                //đóng form cho phép sửa, xóa, làm mới
                Blockform();
                clearForm();
                return;
            }

        }
        private void clearForm()
        {
            txt_madancu.Clear();
            txt_hovatenlot.Clear();
            txt_ten.Clear();


            datepicker_ngaysinh.Value = DateTime.Now;
            rdbtn_nam.Checked = true;
            txt_cmnd.Clear();
            txt_sdt.Clear();

            datepicker_ngaychuyenvao.Value = DateTime.Now;
            txt_macanho.Clear();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearForm();
            Blockform();
        }

        private void btn_xoadancu_Click(object sender, EventArgs e)
        {
            string madancu = txt_madancu.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa dân cư có mã: " + madancu + " không ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int madancunum = Int16.Parse(madancu);
                bool status = quanLyDanCuController.startXoaDanCu(madancunum);
                if (status == true)
                {
                    showError("Xóa dân cư có mã: " + madancu + " thành công");
                    clearForm();
                    Blockform();
                    loadListDanCu();
                }
                else
                {
                    showError("Xóa dân cư thất bại");
                }
            }
        }

        private void btn_suathongtindancu_Click(object sender, EventArgs e)
        {
            string hovatenlot = txt_hovatenlot.Text;
            string ten = txt_ten.Text;
            string ngaysinh = datepicker_ngaysinh.Value.ToString("dd/MM/yyyy");
            int gioitinh = 1;
            if (rdbtn_nu.Checked == true)
            {
                gioitinh = 0;
            }
            string cmnd = txt_cmnd.Text;
            string sdt = txt_sdt.Text;
            string ngaychuyenvao = datepicker_ngaychuyenvao.Value.ToString("dd/MM/yyyy");
            string macanho = txt_macanho.Text;
            if (hovatenlot.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập họ và tên lót");
                txt_hovatenlotnew.Focus();
                return;
            }
            else if (ten.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên");
                txt_ten.Focus();
                return;
            }
            else if (macanho.Trim().Length == 0)
            {
                showError("Vui lòng nhập mã căn hộ");
                txt_ten.Focus();
                return;
            }
            int macanhonum = Int16.Parse(macanho);
            int madancu = Int16.Parse(txt_madancu.Text);
            object[] thongtindancu = { hovatenlot, ten, ngaysinh, gioitinh, cmnd, sdt, ngaychuyenvao, macanhonum, madancu };
            bool status = quanLyDanCuController.startSuaThongTinDanCu(thongtindancu);
            if (status == true)
            {
                showError("Thay đổi thông tin dân cư thành công");
               
                loadListDanCu();
            }
            else
            {
                showError("Thêm dân cư thất bại, kiểm tra lại mã căn hộ");

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_search.Text;
            if(dulieuthongtin.Trim(' ').Length == 0 ){
                loadListDanCu();
            }
            else
            {
                int kieuthongtin = combobox_search.SelectedIndex;
                object dulieuthongtinmoi = dulieuthongtin;
                if (kieuthongtin == 0 || kieuthongtin==3 || kieuthongtin==7) //mã dan cư hoặc giới tính hoặc mã căn hộ
                {
                    try
                    {
                        dulieuthongtinmoi = Int16.Parse(dulieuthongtin);
                    }catch(Exception error)
                    {
                        dulieuthongtinmoi = -1;
                    }

                }
                datagridview_quanlydancu.DataSource = quanLyDanCuController.startTimKiemDanCu(kieuthongtin, dulieuthongtinmoi);

            }
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            loadListDanCu();
            combobox_search.SelectedIndex = 0;
            txt_search.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
