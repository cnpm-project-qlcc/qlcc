using quanlychungcu.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlychungcu
{
    public partial class QuanLyCongNo : Form
    {
        private QuanLyCongNoController quanLyCongNoController;
        private string username;
        public QuanLyCongNo(string username)
        {
            InitializeComponent();
            this.username = username;
            quanLyCongNoController = new QuanLyCongNoController();
            combobox_tinhtrangthanhtoan.SelectedIndex = 0;
            loadListBienLaiThanhToan();
            combobox_search.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void loadListBienLaiThanhToan()
        {
            dataGridView_quanlycongno.DataSource = quanLyCongNoController.getListBienLaiThanhToan();
        }
        private void clearForm()
        {
            txt_mabienlai.Clear();
            txt_macanho.Clear();
            txt_tongtienthanhtoan.Clear();
            datepicker_ngaylap.Value = DateTime.Now;
            combobox_tinhtrangthanhtoan.SelectedIndex = 0;
            txt_nguoilap.Clear();
        }
        private void BlockForm()
        {
            btn_inbienlai.Enabled = false;
            btn_suathongtinbienlai.Enabled = false;
            btn_xoabienlai.Enabled = false;
            btn_lammoi.Enabled = false;
        }
        private void unBlockForm()
        {
            btn_inbienlai.Enabled = true;
            btn_suathongtinbienlai.Enabled = true;
            btn_xoabienlai.Enabled = true;
            btn_lammoi.Enabled = true;
        }

        private void dataGridView_quanlycongno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowSelected = dataGridView_quanlycongno.Rows[e.RowIndex]; //lấy ra row của DataGridView được chọn
                string mabienlai = rowSelected.Cells[0].Value.ToString();
                if(mabienlai.Trim(' ').Length == 0)
                {
                    clearForm();
                    BlockForm();
                    return;
                }
                txt_mabienlai.Text = mabienlai;
                txt_tongtienthanhtoan.Text= rowSelected.Cells[1].Value.ToString();
                txt_macanho.Text= rowSelected.Cells[2].Value.ToString();
                string ngaylap= rowSelected.Cells[3].Value.ToString();
                datepicker_ngaylap.Value = DateTime.ParseExact(ngaylap, "dd/MM/yyyy", null);
                string tinhtrang= rowSelected.Cells[4].Value.ToString();
                combobox_tinhtrangthanhtoan.SelectedIndex = 0;
                if (tinhtrang == "1")
                {
                    combobox_tinhtrangthanhtoan.SelectedIndex = 1;
                }
                txt_nguoilap.Text= rowSelected.Cells[5].Value.ToString();
                unBlockForm();
            }
            catch(Exception error)
            {
                clearForm();
                BlockForm();
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearForm();
            BlockForm();
        }

        private void btn_xoabienlai_Click(object sender, EventArgs e)
        {
            string mabienlai = txt_mabienlai.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa biên lai có mã là: " + mabienlai + " không ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int mabienlainum = Int16.Parse(mabienlai);
                bool status = quanLyCongNoController.startXoaBienLaiThanhToanTheoMaBienLai(mabienlainum);
                if (status == true)
                {
                    showError("Xóa biên lai có mã: " + mabienlai + " thành công ");
                    clearForm();
                    BlockForm();
                    loadListBienLaiThanhToan();
                }
                else
                {
                    showError("Xóa biên lai có mã: " + mabienlai + " thất bại ");
                }
            }
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void btn_suathongtinbienlai_Click(object sender, EventArgs e)
        {
            
            int tinhtrang = combobox_tinhtrangthanhtoan.SelectedIndex;
            int mabienlai = Int16.Parse(txt_mabienlai.Text);
            bool status = quanLyCongNoController.startSuaBienLaiThanhToan(mabienlai, tinhtrang);
            if (status == true)
            {
                showError("Thay đổi thông tin biên lai thành công");
                loadListBienLaiThanhToan();
            }
            else
            {
                showError("Thay đổi thông tin biên lai thất bại, vui lòng thử lại");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_search.Text;
            if (dulieuthongtin.Trim(' ').Length == 0)
            {
                loadListBienLaiThanhToan();
            }
            else
            {
                int kieuthongtin = combobox_search.SelectedIndex;
                object dulieuthongtinmoi = dulieuthongtin;
                if(kieuthongtin==0 || kieuthongtin==1 || kieuthongtin == 3)
                {
                    //mã biên lai || mã căn hộ || tình trạng
                    try
                    {
                        dulieuthongtinmoi = Int16.Parse(dulieuthongtin);
                    }catch(Exception error)
                    {
                        dulieuthongtinmoi = -1;
                    }
                }
                dataGridView_quanlycongno.DataSource = quanLyCongNoController.startTimKiemBienLaiThanhToan(kieuthongtin,dulieuthongtinmoi);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            combobox_search.SelectedIndex = 0;
            txt_search.Clear();
            loadListBienLaiThanhToan();
        }

        private void btn_thembienlai_Click(object sender, EventArgs e)
        {
            ThemBienLai thembienlai = new ThemBienLai(this,this.username);
            thembienlai.ShowDialog();
        }

        private void btn_inbienlai_Click(object sender, EventArgs e)
        {
            string mabienlai = txt_mabienlai.Text;
            string tongtienthanhtoan = txt_tongtienthanhtoan.Text;
            string macanho = txt_macanho.Text;
            string thoigianlap = datepicker_ngaylap.Value.ToString("dd/MM/yyyy");
            string nguoilap = this.username;
            InBienLaiThanhToan inbienlaithanhtoan = new InBienLaiThanhToan(mabienlai, tongtienthanhtoan, macanho, thoigianlap, nguoilap);
            inbienlaithanhtoan.ShowDialog();
        }

        private void dataGridView_quanlycongno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
