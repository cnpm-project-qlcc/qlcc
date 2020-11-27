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
    public partial class QuanLyDichVu : Form
    {
        QuanLyDichVuController quanLyDichVuController;
        QuanLyDanCuController quanLyDanCuController;
        //hai biến dưới đây dùng để lưu lại giá trị khi ta mới click vào 1 cells trong datagrid của bảng sudungdichvu --
        //mục đích là để dành cho việc update
        private int oldMaSoDichVu_SuDungDichVu;
        private string oldThoiGianSuDung_SuDungDichVu;
        public QuanLyDichVu()
        {
            InitializeComponent();
            quanLyDichVuController = new QuanLyDichVuController();
            quanLyDanCuController = new QuanLyDanCuController();
            Blockform();
            combobox_search.SelectedIndex = 0;
            combobox_searchdc.SelectedIndex = 0;
            loadListDichVu();
            loadListDanCuSuDungDichVu();
            loadListMaSoDichVuChoComBoBox();
        }
        private void checkFloatInputTextBox(object sender, KeyPressEventArgs e)//kiểm tra để chỉ cho phép textbox nhập số float
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void loadListDichVu()
        {
            datagridview_quanlydichvu.DataSource = quanLyDichVuController.getListDichVu();
        }
        public void loadListDanCuSuDungDichVu()
        {
            DataTable listDanCuSuDungDichVu = quanLyDichVuController.getListDanCuSuDungDichVu();
            datagridview_dancusudungdichvu.DataSource = listDanCuSuDungDichVu;

        }
        private void loadListMaSoDichVuChoComBoBox() //ta sẽ lấy các mã dịch vụ và gán cho combobox ở phần dân cư sử dụng dịch vụ
        {
            DataTable listMaSoDichVu = quanLyDichVuController.getListMaSoDichVu();
            combobox_masodichvudc.DataSource = listMaSoDichVu;
            combobox_masodichvudc.DisplayMember = "masodichvu";
            combobox_masodichvudc.ValueMember = "masodichvu";

        }
        private void txt_giamoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkFloatInputTextBox(sender, e);
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void datagridview_quanlydichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
                DataGridViewRow rowSelected = datagridview_quanlydichvu.Rows[e.RowIndex]; //lấy ra
                txt_madichvu.Text = rowSelected.Cells[0].Value.ToString();
                txt_tendichvu.Text = rowSelected.Cells[1].Value.ToString();
                txt_gia.Text = rowSelected.Cells[2].Value.ToString();
                unBlockform();
            }
            catch (Exception errror)
            {

                clearForm();
                Blockform();
            }
        }
        private void unBlockform()
        {
            btn_lammoi.Enabled = true;
            btn_suathongtindichvu.Enabled = true;
            btn_xoadichvu.Enabled = true;
        }
        private void Blockform()
        {
            btn_lammoi.Enabled = false;
            btn_suathongtindichvu.Enabled = false;
            btn_xoadichvu.Enabled = false;
        }
        private void clearForm()
        {
            txt_madichvu.Clear();
            txt_gia.Clear();
            txt_tendichvu.Clear();
        }

        private void btn_suathongtindichvu_Click(object sender, EventArgs e)
        {
            string masodichvu = txt_madichvu.Text;
            if (masodichvu.Length == 0)
            {
                Blockform();
                return;
            }
            string tendichvu = txt_tendichvu.Text;
            string gia = txt_gia.Text;
            if (tendichvu.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên dịch vụ");
                txt_tendichvu.Focus();
                return;
            }
            else if (gia.Trim().Length == 0)
            {
                showError("Vui lòng nhập giá dịch vụ");
                txt_gia.Focus();
                return;
            }
            int masodichvunum = Int16.Parse(masodichvu);
            float gianum = (float)Convert.ToDouble(gia);
            bool status = quanLyDichVuController.startSuaDichVu(masodichvunum, tendichvu, gianum);
            if (status == true)
            {
                showError("Thay đổi thông tin dịch vụ thành công");
                loadListDichVu();
            }
            else
            {
                showError("Thay đổi thông tin dịch vụ thất bại, vui lòng kiểm tra và nhập lại");
            }
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkFloatInputTextBox(sender, e);
        }

        private void btn_xoadichvu_Click(object sender, EventArgs e)
        {
            string masodichvu = txt_madichvu.Text;
            if (masodichvu.Length == 0)
            {
                Blockform();
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là bạn muốn xóa dịch vụ có mã số là: " + masodichvu + " không ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int masodichvunum = Int16.Parse(masodichvu);
                bool status = quanLyDichVuController.startXoaDichVu(masodichvunum);
                if (status == true)
                {
                    showError("Xóa dịch vụ thành công");
                    loadListDichVu();
                    loadListMaSoDichVuChoComBoBox();// load lại thêm cái mã số cho combobox ở phần dân cư sử dụng dịch vụ
                    loadListDanCuSuDungDichVu(); //load lại thêm bảng dân cư sử dụng dịch 

                }
                else
                {
                    showError("Xóa dịch vụ thất bại, vui lòng thử lại");
                }
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clearForm();
            Blockform();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string thongtindulieu = txt_search.Text;
            if (thongtindulieu.Trim(' ').Length == 0)
            {
                loadListDichVu();
            }
            else
            {
                int kieudulieu = combobox_search.SelectedIndex;
                object thongtindulieumoi = thongtindulieu;
                if (kieudulieu == 0) // mã số
                {
                    try
                    {
                        thongtindulieumoi = Int16.Parse(thongtindulieu);
                    }
                    catch (Exception error)
                    {
                        thongtindulieumoi = -1;
                    }
                }
                else if (kieudulieu == 2) //giá
                {
                    try
                    {
                        thongtindulieumoi = (float)Convert.ToDouble(thongtindulieu);
                    }
                    catch (Exception error)
                    {
                        thongtindulieumoi = -1;
                    }
                }
                datagridview_quanlydichvu.DataSource = quanLyDichVuController.startTimKiemDichVu(kieudulieu, thongtindulieumoi);
            }
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            combobox_search.SelectedIndex = 0;
            txt_search.Clear();
            loadListDichVu();
        }

        private void datagridview_dancusudungdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            try
            {
                DataGridViewRow rowSelected = datagridview_dancusudungdichvu.Rows[e.RowIndex]; //lấy ra
                //tìm vị trí của combobox có chứa mã dịch vụ và set cho nó hiển thị vị trí đó
                string masodichvu= rowSelected.Cells[0].Value.ToString();
                int indexOfMaSo = combobox_masodichvudc.FindString(masodichvu);
                combobox_masodichvudc.SelectedIndex=indexOfMaSo;
                //
                txt_tendichvudc.Text = rowSelected.Cells[1].Value.ToString();
                txt_giadc.Text = rowSelected.Cells[2].Value.ToString();
                txt_madancudc.Text = rowSelected.Cells[3].Value.ToString();
                datepicker_ngaysudungdc.Value = DateTime.ParseExact(rowSelected.Cells[4].Value.ToString(), "dd/MM/yyyy", null);

                //Lưu lại giá trị mã số dịch vụ và thời gian sử dụng dành cho việc update
                oldMaSoDichVu_SuDungDichVu = Int16.Parse(masodichvu);
                oldThoiGianSuDung_SuDungDichVu= rowSelected.Cells[4].Value.ToString();

                unBlockDanCuSuDungDichVuForm();
            }
            catch (Exception errror)
            {

                clearDanCuSuDungDichVuForm();
                BlockDanCuSuDungDichVuForm();
            }
        }
        private void BlockDanCuSuDungDichVuForm()
        {
            btn_suathongtindancusudungdichvu.Enabled = false;
            btn_xoadancusudungdichvu.Enabled = false;
            btn_cleardancusudungdichvu.Enabled = false;
        }
        private void unBlockDanCuSuDungDichVuForm()
        {
            btn_suathongtindancusudungdichvu.Enabled = true;
            btn_xoadancusudungdichvu.Enabled = true;
            btn_cleardancusudungdichvu.Enabled = true;
        }
        private void clearDanCuSuDungDichVuForm()
        {
            combobox_masodichvudc.SelectedIndex = 0;
            txt_tendichvudc.Clear();
            txt_giadc.Clear();
            txt_madancudc.Clear();
            datepicker_ngaysudungdc.Value = DateTime.Now;
        }

        private void btn_suathongtindancusudungdichvu_Click(object sender, EventArgs e) //ta chỉ cho phép sửa loại dịch vụ và ngày sử dụng
        {
            //lấy thông tin từ combobox -- do combox ta liên kết với dataTable nên cách lấy hơi phức tạp
            DataRowView masodichvuitem = (DataRowView)combobox_masodichvudc.SelectedItem;
            int masodichvu = Int16.Parse( masodichvuitem.Row["masodichvu"].ToString());
            int masodancu = Int16.Parse(txt_madancudc.Text);
            string ngaysudung = datepicker_ngaysudungdc.Value.ToString("dd/MM/yyyy");
            bool status = quanLyDichVuController.startSuaThongTinDanCuSuDungDichVu(masodichvu, masodancu, ngaysudung, oldMaSoDichVu_SuDungDichVu, oldThoiGianSuDung_SuDungDichVu);
            if(status == true)
            {
                showError("Thay đổi thông tin dân cư sử dụng dịch vụ thành công");
                loadListDanCuSuDungDichVu();
            }
            else
            {
                showError("Thay đổi thông tin dân cư sử dụng dịch vụ thất bại, vui lòng thử lại");
            }
        }

        private void combobox_masodichvudc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btn_themdichvu_Click(object sender, EventArgs e)
        {
            string tendichvu = txt_tendichvumoi.Text;
            string gia = txt_giamoi.Text;
            if (tendichvu.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên dịch vụ");
                txt_tendichvumoi.Focus();
                return;
            }
            else if (gia.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập giá của dịch vụ");
                txt_giamoi.Focus();
                return;
            }
            float gianum = (float)Convert.ToDouble(gia);
            bool status = quanLyDichVuController.startThemDichVu(tendichvu, gianum);
            if (status == true)
            {
                showError("Thêm dịch vụ mới thành công");
                txt_giamoi.Clear();
                txt_tendichvumoi.Clear();
                loadListDichVu();
                loadListMaSoDichVuChoComBoBox();
            }
            else
            {
                showError("Thêm dịch vụ mới thất bại");
            }
        }

        private void txt_giamoi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            checkFloatInputTextBox(sender,e);
        }

        private void btn_xoadancusudungdichvu_Click(object sender, EventArgs e)
        {
            int madancu = Int16.Parse(txt_madancudc.Text);
            //có thể trước khi xóa, người dùng sẽ thay đổi giá trị => hoạt động sai => giải pháp : chỉ cần sử dụng giá trị được lưu khi mới click vào một cell để xóa là được
            int masodichvu = oldMaSoDichVu_SuDungDichVu;
            string thoigiansudung = oldThoiGianSuDung_SuDungDichVu;
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là bạn muốn xóa chứ ?", " ", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                bool status = quanLyDichVuController.startXoaDanCuSuDungDichVu(masodichvu, madancu, thoigiansudung);
                if (status == true)
                {
                    showError("Xóa dân cư sử dụng dịch vụ thành công");
                    loadListDanCuSuDungDichVu();
                    BlockDanCuSuDungDichVuForm();
                    clearDanCuSuDungDichVuForm();
                }
                else
                {
                    showError("Xóa dân cư sử dụng dịch vụ thất bại, vui lòng thử lại sau ");
                }
            }
            
           

        }

        private void btn_cleardancusudungdichvu_Click(object sender, EventArgs e)
        {
            BlockDanCuSuDungDichVuForm();
            clearDanCuSuDungDichVuForm();
        }

        private void btn_searchdc_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_searchdc.Text;
            if(dulieuthongtin.Trim(' ').Length == 0)
            {
                loadListDanCuSuDungDichVu();
            }
            else
            {
                int kieuthongtin = combobox_searchdc.SelectedIndex;
                object dulieuthongtinmoi = dulieuthongtin;
                if (kieuthongtin == 0 || kieuthongtin==1)
                {
                    try
                    {
                        dulieuthongtinmoi = Int16.Parse(dulieuthongtin);
                    }catch(Exception errror)
                    {
                        dulieuthongtinmoi = -1;
                    }
                }
                datagridview_dancusudungdichvu.DataSource = quanLyDichVuController.startTimKiemDanCuSuDungDichVu(kieuthongtin, dulieuthongtinmoi);
            }
        }

        private void btn_cleardc_Click(object sender, EventArgs e)
        {
            txt_searchdc.Clear();
            combobox_searchdc.SelectedIndex = 0;
            loadListDanCuSuDungDichVu();
        }

        private void btn_themdancusudungdichvu_Click(object sender, EventArgs e)
        {
            ThemDanCuSuDungDichVu themDanCuSuDungDichVu = new ThemDanCuSuDungDichVu(this);
            themDanCuSuDungDichVu.ShowDialog();
        }

        private void datagridview_dancusudungdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
