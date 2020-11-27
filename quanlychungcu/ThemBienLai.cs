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
    public partial class ThemBienLai : Form
    {
        private string username;
        private QuanLyCongNo quanlyCongno;
        private QuanLyCongNoController quanLyCongNoController;
        private QuanLyCanHoController quanLyCanHoController;
        public ThemBienLai(QuanLyCongNo quanlyCongno, string username)
        {
            InitializeComponent();
            this.quanlyCongno = quanlyCongno;
            this.username = username;
            setMinMaxDatePicker();
            combobox_search.SelectedIndex = 0;
            combobox_tinhtrangcanho.SelectedIndex = 0;
            quanLyCanHoController = new QuanLyCanHoController();
            quanLyCongNoController = new QuanLyCongNoController();
            loadListCanHoKhongTrong();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loadListCanHoKhongTrong() //chỉ lấy những căn hộ có người ở để thực hiện in biên lai
        {
            dataGridView_canho.DataSource = quanLyCanHoController.getListCanHoKhongTrong();
        }
        private void unBlockForm()
        {
            btn_taobienlai.Enabled = true;
            btn_lammoi.Enabled = true;
            datepicker_thoigianlap.Enabled = true;

        }
        private void BlockForm()
        {
            btn_taobienlai.Enabled = false;
            btn_lammoi.Enabled = false;
            datepicker_thoigianlap.Enabled = false;
        }
        private void clearForm()
        {
            txt_macanho.Clear();
            txt_phicanho.Clear();
            txt_phidichvu.Clear();
            txt_tongtienthanhtoan.Clear();
            combobox_tinhtrangcanho.SelectedIndex = 0;
            datepicker_thoigianlap.Value = DateTime.Now;
            txt_nguoilap.Clear();
        }
        private void setMinMaxDatePicker() //cho phép lập biên lai thanh toán trong phạm vi chỉ trong tháng trước hoặc tháng hiện tại
        {
            DateTime minDate = DateTime.Now.AddMonths(-1);
            DateTime maxDate = DateTime.Now.AddHours(1);
            datepicker_thoigianlap.MinDate = minDate;
            datepicker_thoigianlap.MaxDate = maxDate;
        }

        private void dataGridView_canho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowSelected = dataGridView_canho.Rows[e.RowIndex];
                string macanho = rowSelected.Cells[0].Value.ToString();
                if(macanho.Trim(' ').Length == 0)
                {
                    BlockForm();
                    clearForm();
                    return;
                }
                txt_macanho.Text = macanho;
                int tinhtrang = (int)rowSelected.Cells[3].Value;
                combobox_tinhtrangcanho.SelectedIndex = tinhtrang;
                if(tinhtrang != 3) //nếu đang mua trả góp hoặc thuê thì mới tính phí căn hộ vào
                {
                    txt_phicanho.Text = rowSelected.Cells[2].Value.ToString();
                }
                else
                {
                    txt_phicanho.Text = "0";
                }
                string thoigianlap = datepicker_thoigianlap.Value.ToString("dd/MM/yyyy");
                string thoigianlapwithMonthandyear = thoigianlap.Substring(3);
                int macanhonum = Int16.Parse(macanho);
                
                object phidichvu = quanLyCongNoController.getPhiDichVuTheoThoiGianCuaCanHo(macanhonum, thoigianlapwithMonthandyear);
                string phidichvunew="0";
                if (phidichvu != null)
                {
                    phidichvunew = phidichvu.ToString();
                }
               
                txt_phidichvu.Text = phidichvunew;
                float tongtienthanhtoan = (float)Convert.ToDouble(txt_phicanho.Text) + (float)Convert.ToDouble(txt_phidichvu.Text);
                txt_tongtienthanhtoan.Text = tongtienthanhtoan.ToString();
                txt_nguoilap.Text = username;
                unBlockForm();
            }
            catch(Exception error)
            {
                //MessageBox.Show(error.Message);
                BlockForm();
                clearForm();
            }
        }

        private void datepicker_thoigianlap_ValueChanged(object sender, EventArgs e) // khi thay đổi thời gian lập, ta cũng phải cập nhật lại giá trị phí dịch vụ
        {
            try
            {
                int macanhonum = Int16.Parse(txt_macanho.Text);
                string thoigianlap = datepicker_thoigianlap.Value.ToString("dd/MM/yyyy");
                string thoigianlapwithMonthandyear = thoigianlap.Substring(3);
                object phidichvu = quanLyCongNoController.getPhiDichVuTheoThoiGianCuaCanHo(macanhonum, thoigianlapwithMonthandyear);
                string phidichvunew = "0";
                if (phidichvu != null)
                {
                    phidichvunew = phidichvu.ToString();
                }

                txt_phidichvu.Text = phidichvunew;
                float tongtienthanhtoan = (float)Convert.ToDouble(txt_phicanho.Text) + (float)Convert.ToDouble(txt_phidichvu.Text);
                txt_tongtienthanhtoan.Text = tongtienthanhtoan.ToString();
            }
            catch(Exception error)
            {
                BlockForm();
                
            }
            
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            BlockForm();
            clearForm();
        }

        private void btn_taobienlai_Click(object sender, EventArgs e)
        {
            string sotienthanhtoan = txt_tongtienthanhtoan.Text;
            float sotienthanhtoannew = (float)Convert.ToDouble(sotienthanhtoan);
            int macanho = Int16.Parse(txt_macanho.Text);
            string thoigianlap = datepicker_thoigianlap.Value.ToString("dd/MM/yyyy");
            int tinhtrang = 0; //miows tạo thì mặc định là chưa thanh toán
            string username = txt_nguoilap.Text;
            bool status = quanLyCongNoController.startThemBienLai(sotienthanhtoannew, macanho, thoigianlap, tinhtrang, username);
            if(status == true)
            {
                showError("Tạo biên lai thanh toán thành công");
                BlockForm();
                clearForm();
                quanlyCongno.loadListBienLaiThanhToan();
            }
            else
            {
                showError("Tạo biên lai thanh toán không thành công, vui lòng thử lại sau");
            }
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_search.Text;
            if (dulieuthongtin.Trim(' ').Length == 0)
            {
                loadListCanHoKhongTrong();
            }
            else
            {
                object dulieuthongtinnew = dulieuthongtin;
                int thongtin = combobox_search.SelectedIndex;
                if (thongtin == 0 || thongtin == 2) //nếu người dugnf muốn tìm theo id hoặc theo tình trạng (là mã số)
                {
                    try //lỡ người dùng nhập mã là string hay float thì có thể ra lỗi
                    {
                        dulieuthongtinnew = Int16.Parse(dulieuthongtin);
                    }
                    catch (Exception error)
                    {
                        dulieuthongtinnew = -1;
                    }
                }
                else if (thongtin == 3) //nếu người dùng theo giá cả
                {
                    try //lỡ người dùng nhập mã là string  thì có thể ra lỗi
                    {
                        dulieuthongtinnew = (float)Convert.ToDouble(dulieuthongtin);
                    }
                    catch (Exception error)
                    {
                        dulieuthongtinnew = 0;
                    }

                }
                dataGridView_canho.DataSource = quanLyCanHoController.startTimKiemCanHo(thongtin, dulieuthongtinnew);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            combobox_search.SelectedIndex = 0;
            txt_search.Clear();
            loadListCanHoKhongTrong();
        }
    }
}
