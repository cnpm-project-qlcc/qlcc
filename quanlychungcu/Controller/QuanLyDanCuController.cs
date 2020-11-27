using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class QuanLyDanCuController
    {
        private QuanLyDichVuController quanLyDichVuController;
        public QuanLyDanCuController()
        {
            quanLyDichVuController = new QuanLyDichVuController();
        }
        private bool startExecuteNonquery(string querystring, object[] para) //hàm thực hiện chạy câu lệnh executeNonquery
        {
            
            try
            {
                int status = DataProvider.Instance.ExecuteNonQuery(querystring, para);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
        public DataTable getListDanCu()
        {
            string querystring = "select * from dancu ";
            object[] para = {  };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public bool startThemDanCu(object[] thongtindancu)
        {
            
            string querystring = "insert into dancu values( @hovatenlot ,  @ten ,  @ngaysinh ,  @gioitinh ,  @cmnd ," +
                "  @sdt ,  @ngaychuyenvao , @macanho )";
            object[] para = thongtindancu;
            return startExecuteNonquery(querystring, para);
        }
        public bool startSuaThongTinDanCu(object[] thongtindancu)
        {
            string querystring = " update dancu set hovatenlot = @hovatenlot ,  ten = @ten ,  ngaysinh = @ngaysinh ,  gioitinh = @gioitinh ,  cmnd = @cmnd" +
                " , sdt = @sdt , ngaychuyenvao = @ngaychuyenvao , macanho = @macanho where madancu = @madancu ";
            object[] para = thongtindancu;
            return startExecuteNonquery(querystring, para);
        }
        public List<int> getListMaDanCuTheoMaCanHo(int macanho) //hàm trả về toàn bộ mã dân cư theo căn hộ
        {
            string querystring = "select madancu from dancu where macanho = @macanho ";
            object[] para = { macanho };
            DataTable dataMaDanCuTheoMaCanHo= DataProvider.Instance.ExecuteQuery(querystring, para);
            List<int> listMaDanCu = new List<int>();
            for(int i=0; i < dataMaDanCuTheoMaCanHo.Rows.Count; i++)
            {
                listMaDanCu.Add((int)dataMaDanCuTheoMaCanHo.Rows[i]["madancu"]);
            }
            return listMaDanCu;
        }
        public bool startXoaDanCuTheoMaCanHo(int macanho)
        {
            //muốn xóa bảng dân cư, phải xóa bảng sử dụng dịch vụ trước
            List<int> listMaDanCu = getListMaDanCuTheoMaCanHo(macanho);
            foreach(int madancu in listMaDanCu)
            {
                quanLyDichVuController.startXoaSuDungDichVu(madancu);
            }
            //DataTable dataMaDanCuTheoMaCanHo = getListMaDanCuTheoMaCanHo(macanho);
            string querystring = "delete from dancu where macanho = @macanho ";
            object[] para = { macanho };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaDanCu(int madancu)
        {
            //phải xóa trong bảng sử dụng dịch vụ trước
            quanLyDichVuController.startXoaSuDungDichVu(madancu);
            string querystring = "delete from dancu where madancu = @madancu ";
            object[] para = { madancu };
            return startExecuteNonquery(querystring, para);
        }
        
        public DataTable startTimKiemDanCu(int kieuthongtin, object dulieuthongtin)
        {
            string[] arrConditionQuery =
            {
                " madancu = @madancu ",
                " (hovatenlot + ' ' + ten) = @hoten ",
                " ngaysinh = @ngaysinh ",
                " gioitinh = @gioitinh ",
                " cmnd= @cmnd ",
                " sdt = @sdt ",
                " ngaychuyenvao = @ngaychuyenvao ",
                "macanho = @macanho "
            };
            string querystring = "select * from dancu where " + arrConditionQuery[kieuthongtin];
            object[] para = { dulieuthongtin };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }

    }
}
