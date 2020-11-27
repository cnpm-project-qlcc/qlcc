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
    public partial class QuanLyCanHo : Form
    {
        QuanLyCanHoController quanLyCanHoController;
        public QuanLyCanHo()
        {
            InitializeComponent();
            quanLyCanHoController = new QuanLyCanHoController();
            combobox_search.SelectedIndex = 0;
            combobox_tinhtrangcanho.SelectedIndex = 0;
        }

        private void txt_giacanhomoi_TextChanged(object sender, EventArgs e)
        {
            
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
        private void txt_giacanhomoi_KeyPress(object sender, KeyPressEventArgs e) // khi người dùng gõ vào ô textbox liên quan đến giá cả thì check
                                                                                //xem có phải giá trị float không ?
        {
            checkFloatInputTextBox(sender, e);
        }

        private void btn_themcanho_Click(object sender, EventArgs e)
        {
            string tencanho = txt_tencanhomoi.Text;
            string giacanho = txt_giacanhomoi.Text;
            if (tencanho.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập tên căn hộ");
                txt_tencanhomoi.Focus();
                return;
            }
            else if(giacanho.Trim(' ').Length == 0)
            {
                showError("Vui lòng nhập giá của căn hộ");
                txt_giacanhomoi.Focus();
                return;
            }
            else
            {
                float giacanhonum = (float)Convert.ToDouble(giacanho);
                bool status = quanLyCanHoController.startThemCanHo(tencanho, giacanhonum);
                if (status == true)
                {
                    showError("Thêm căn hộ mới thành công");
                    txt_tencanhomoi.Clear();
                    txt_giacanhomoi.Clear();
                    //gọi hàm load lại list căn hộ
                    loadListCanHo();
                }
                else
                {
                    showError("Tên căn hộ đã tồn tại, vui lòng chọn tên khác");
                }
                
            }
        }
        private void showError(string errormessage)
        {
            MessageBox.Show(errormessage);
        }

        private void QuanLyCanHo_Load(object sender, EventArgs e)
        {
            loadListCanHo();
        }
        private void loadListCanHo()
        {
            DataTable dataTable= quanLyCanHoController.getListCanHo();
            datagridview_quanlycanho.DataSource = dataTable;
        }

        private void datagridview_quanlycanho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewRow rowSelected = datagridview_quanlycanho.Rows[e.RowIndex]; //lấy ra row của DataGridView được chọn
                txt_macanho.Text = rowSelected.Cells[0].Value.ToString();
                txt_tencanho.Text = rowSelected.Cells[1].Value.ToString();
                txt_giacanho.Text = rowSelected.Cells[2].Value.ToString();
                int tinhtrang = (int)rowSelected.Cells[3].Value;
                combobox_tinhtrangcanho.SelectedIndex = tinhtrang;
                //mở form cho phép sửa, xóa, làm mới
                unBlockform();
                
            }
            catch (Exception error)
            {
                //đóng form cho phép sửa, xóa, làm mới
                Blockform();
                return;
            }
            

        }
        private void unBlockform()
        {
            btn_lammoi.Enabled = true;
            btn_suathongtincanho.Enabled = true;
            btn_xoacanho.Enabled = true;
        }
        private void Blockform()
        {
            btn_lammoi.Enabled = false;
            btn_suathongtincanho.Enabled = false;
            btn_xoacanho.Enabled = false;
        }

        private void btn_xoacanho_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc bạn muốn xóa căn hộ có mã là: " + txt_macanho.Text +" ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int macanho = Int16.Parse(txt_macanho.Text);
                bool status= quanLyCanHoController.startXoaCanHo(macanho);
                if(status == true)
                {
                    showError("Bạn đã xóa thành công căn hộ có mã: " + txt_macanho.Text);
                    Blockform();
                    clearForm();
                    loadListCanHo();

                }
                else
                {
                    showError("Xóa căn hộ không thành công");
                }
            }
        }

        private void btn_suathongtincanho_Click(object sender, EventArgs e)
        {
            int macanho = Int16.Parse(txt_macanho.Text);
            string tencanho = txt_tencanho.Text;
            string giacanho = txt_giacanho.Text;
           
            if(tencanho.Trim(' ').Length == 0)
            {
                showError("Vui lòng không để trống tên căn hộ");
                txt_tencanho.Focus();
                return;
            }
            else if(giacanho.Trim(' ').Length == 0)
            {
                showError("Vui lòng không để trống giá căn hộ");
                txt_giacanho.Focus();
                return;
            }
            int tinhtrangcanho = combobox_tinhtrangcanho.SelectedIndex;
            float giacanhonum = (float)Convert.ToDouble(giacanho);
            bool status= quanLyCanHoController.startSuaCanHo(macanho, tencanho, giacanhonum, tinhtrangcanho);
            if(status == true)
            {
                showError("Sửa thông tin căn hộ thành công");
                loadListCanHo();
            }
            else
            {
                showError("Sửa thông tin căn hộ không thành công, vui lòng kiểm tra lại thông tin");
                clearForm();
                Blockform();
            }

        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Blockform();
            clearForm();
        }

        private void txt_giacanho_KeyPress(object sender, KeyPressEventArgs e) //check input là float hay khoog ?
        {
            checkFloatInputTextBox(sender, e);
        }
        public void clearForm()
        {
            txt_macanho.Clear();
            txt_tencanho.Clear();
            txt_giacanho.Clear();
            combobox_tinhtrangcanho.SelectedIndex = 0;
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            loadListCanHo();
            combobox_search.SelectedIndex = 0;
            txt_search.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string dulieuthongtin = txt_search.Text;
            if(dulieuthongtin.Trim(' ').Length == 0)
            {
                loadListCanHo();
            }
            else
            {
                object dulieuthongtinnew = dulieuthongtin;
                int thongtin = combobox_search.SelectedIndex;
                if (thongtin == 0 || thongtin==2) //nếu người dugnf muốn tìm theo id hoặc theo tình trạng (là mã số)
                {
                    try //lỡ người dùng nhập mã là string hay float thì có thể ra lỗi
                    {
                         dulieuthongtinnew = Int16.Parse(dulieuthongtin);
                    }
                    catch(Exception error)
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
                datagridview_quanlycanho.DataSource= quanLyCanHoController.startTimKiemCanHo(thongtin, dulieuthongtinnew);
                
            }
        }
    }
}
