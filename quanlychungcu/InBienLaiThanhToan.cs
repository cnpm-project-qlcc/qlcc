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
   
    public partial class InBienLaiThanhToan : Form
    {
        private QuanLyCongNoController quanLyCongNoController; 
        public InBienLaiThanhToan(string mabienlai, string tongtienthanhtoan, string macanho, string thoigianlap, string nguoilap)
        {
            InitializeComponent();
            quanLyCongNoController = new QuanLyCongNoController();
            lb_thangnamthanhtoan.Text = thoigianlap.Substring(3);
            lb_mabienlai.Text = mabienlai;
            lb_macanho.Text = macanho;
            lb_nguoilap.Text = nguoilap;
            lb_phicanho.Text = getPhiCanHo(macanho) + " VNĐ";
            lb_dichvuthangnam.Text= thoigianlap.Substring(3);
            lb_tongphidichvu.Text = getPhiDichVu(macanho, thoigianlap) + " VNĐ";
            lb_tongtienthanhtoan.Text = tongtienthanhtoan +" VNĐ";
            loadListDanCuSuDungDichVu(macanho,thoigianlap);
        }
        public void loadListDanCuSuDungDichVu(string macanho, string thoigianlap)
        {
            int macanhonum = Int16.Parse(macanho);
            string thoigianlapnew = thoigianlap.Substring(3);
            dataGridView_sudungdichvu.DataSource = quanLyCongNoController.getListDanCuSuDungDichVu(macanhonum, thoigianlapnew);
        }
        public string getPhiCanHo(string macanho)
        {
            int macanhonum = Int16.Parse(macanho);

            object giacanho = quanLyCongNoController.getPhiCanHo(macanhonum);
            if(giacanho == null)
            {
                return "0";
            }
            else
            {
                return giacanho.ToString();
            }
        }
        public string getPhiDichVu(string macanho, string ngaylap)
        {
            int macanhonum = Int16.Parse(macanho);
            string ngaylapnew=ngaylap.Substring(3);
            object phidichvu = quanLyCongNoController.getPhiDichVuTheoThoiGianCuaCanHo(macanhonum, ngaylapnew);
            if (phidichvu == null)
            {
                return "0";
            }
            else
            {
                return phidichvu.ToString();
            }
        }

        private void btn_inbienlai_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Đã tiến thành in", "", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
