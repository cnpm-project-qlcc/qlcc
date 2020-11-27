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
    public partial class ThemDanCuSuDungDichVu : Form
    {
        private QuanLyDichVu quanlyDichVu;
        private QuanLyDanCuController quanLyDanCuController;
        private QuanLyDichVuController quanLyDichVuController;
        private int unclockxacnhanDanCu= 0;
        private int unclockxacnhanDichVu = 0;
        public ThemDanCuSuDungDichVu()
        {
            InitializeComponent();
        }
        public ThemDanCuSuDungDichVu(QuanLyDichVu quanlyDichVu)
        {
            InitializeComponent();
            this.quanlyDichVu = quanlyDichVu;
            this.quanLyDanCuController = new QuanLyDanCuController();
            this.quanLyDichVuController = new QuanLyDichVuController();
            combobox_searchdc.SelectedIndex = 0;
            combobox_searchdv.SelectedIndex = 0;
            loadData();
        }
        private void loadDataDanCu()
        {
            datagrid_dancu.DataSource = quanLyDanCuController.getListDanCu();
        }
        private void loadDataDichVu()
        {
            datagrid_dichvu.DataSource = quanLyDichVuController.getListDichVu();
        }
        private void loadData()
        {

            loadDataDanCu();
            loadDataDichVu();
        }
        private void BlockForm()
        {
            
            btn_xacnhan.Enabled = false;
            
        }
        private void unBlockForm()
        {
            btn_clearformdichvu.Enabled = true;
            btn_xacnhan.Enabled = true;
        }
        private void clearFormDichVu()
        {
            txt_masodichvu.Clear();
            txt_tendichvu.Clear();
            txt_gia.Clear();
            datepicker_thoigiansudung.Value = DateTime.Now;
            BlockForm();
        }
        private void clearFormDanCu()
        {
            txt_madancu.Clear();
            txt_hovaten.Clear();
            txt_macanho.Clear();
            BlockForm();
        }
        private void clearForm()
        {

            clearFormDichVu();
            clearFormDanCu();

        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }
        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            int madancu= Int16.Parse(txt_madancu.Text);
            int masodichvu = Int16.Parse(txt_masodichvu.Text);
            string thoigiansudung = datepicker_thoigiansudung.Value.ToString("dd/MM/yyyy");
            bool status = quanLyDichVuController.startThemDanCuSuDungDichVu(madancu, masodichvu, thoigiansudung);
            if(status == true)
            {
                showError("Thêm thông tin dân cư sử dụng dịch vụ thành công");
                quanlyDichVu.loadListDanCuSuDungDichVu();
                clearForm();
            }
            else
            {
                showError("Thêm thông tin dân cư sử dụng dịch vụ thất bại, vui lòng thử lại");
            }
        }

        private void datagrid_dichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowSelected = datagrid_dichvu.Rows[e.RowIndex]; //lấy ra row của DataGridView được chọn
                string madichvu = rowSelected.Cells[0].Value.ToString();
                if (madichvu.Trim(' ').Length == 0)// nếu bấm vào vùng trống
                {
                    unclockxacnhanDichVu = 0;
                    clearFormDichVu();
                    BlockForm();
                    return;
                }
                txt_masodichvu.Text = madichvu;
                txt_tendichvu.Text = rowSelected.Cells[1].Value.ToString();
                txt_gia.Text = rowSelected.Cells[2].Value.ToString();
                unclockxacnhanDichVu = 1;
                if (unclockxacnhanDanCu == 1)
                {
                    unBlockForm();
                }
            }
            catch(Exception error)
            {
                unclockxacnhanDichVu = 0;
                clearFormDichVu();
                BlockForm();
            }
        }

        private void datagrid_dancu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowSelected = datagrid_dancu.Rows[e.RowIndex]; //lấy ra row của DataGridView được chọn
                string madancu = rowSelected.Cells[0].Value.ToString();
                if (madancu.Trim(' ').Length == 0)// nếu bấm vào vùng trống
                {
                    unclockxacnhanDanCu = 0;
                    clearFormDanCu();
                    BlockForm();
                    return;
                }
                txt_madancu.Text = madancu;
                txt_hovaten.Text = rowSelected.Cells[1].Value.ToString() + " " + rowSelected.Cells[2].Value.ToString();
                txt_macanho.Text = rowSelected.Cells[8].Value.ToString();

                unclockxacnhanDanCu = 1;
                
                if (unclockxacnhanDichVu == 1)
                {
                    unBlockForm();
                }
            }
            catch (Exception error)
            {
                unclockxacnhanDanCu = 0;
                clearFormDanCu();
                BlockForm();
            }
        }

        private void btn_clearformdancu_Click(object sender, EventArgs e)
        {
            clearFormDanCu();
        }

        private void btn_clearformdichvu_Click(object sender, EventArgs e)
        {
            clearFormDichVu();
        }

        private void btn_searchdv_Click(object sender, EventArgs e)
        {
            string thongtindulieu = txt_searchdv.Text;
            if (thongtindulieu.Trim(' ').Length == 0)
            {
                loadDataDichVu();
            }
            else
            {
                int kieudulieu = combobox_searchdv.SelectedIndex;
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
                datagrid_dichvu.DataSource = quanLyDichVuController.startTimKiemDichVu(kieudulieu, thongtindulieumoi);
            }
        }

        private void btn_cleardv_Click(object sender, EventArgs e)
        {
            combobox_searchdv.SelectedIndex = 0;
            txt_searchdv.Clear();
            loadDataDichVu();
        }

        private void btn_cleardc_Click(object sender, EventArgs e)
        {
            combobox_searchdc.SelectedIndex = 0;
            txt_searchdc.Clear();
            loadDataDanCu();
        }

        private void btn_searchdc_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_searchdc.Text;
            if (dulieuthongtin.Trim(' ').Length == 0)
            {
                loadDataDanCu();
            }
            else
            {
                int kieuthongtin = combobox_searchdc.SelectedIndex;
                object dulieuthongtinmoi = dulieuthongtin;
                if (kieuthongtin==0 || kieuthongtin == 3 || kieuthongtin == 7) //mã dân cư hoặc giới tính hoặc mã căn hộ
                {
                    try
                    {
                        dulieuthongtinmoi = Int16.Parse(dulieuthongtin);
                    }
                    catch (Exception error)
                    {
                        dulieuthongtinmoi = -1;
                    }

                }
                datagrid_dancu.DataSource = quanLyDanCuController.startTimKiemDanCu(kieuthongtin, dulieuthongtinmoi);

            }
        }

        private void datagrid_dancu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
