using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class QuanLyCanHoController
    {
        private QuanLyDanCuController quanLyDanCuController;
        private QuanLyCongNoController quanLyCongNoController;
          public QuanLyCanHoController()
        {
            quanLyDanCuController = new QuanLyDanCuController();
            quanLyCongNoController = new QuanLyCongNoController();
        }
        public DataTable getListCanHo()
        {
            string querystring = "select * from canhochungcu ";
            object[] para = { };
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(querystring, para);
            return dataTable;
        }
        public DataTable getListCanHoKhongTrong(){ //lấy những căn hộ có người ở (tức là đang được thuê, mua góp hoặc mua)
            string querystring = "select * from canhochungcu where tinhtrangcanho != 0";
            object[] para = { };
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(querystring, para);
            return dataTable;
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
        public bool startThemCanHo(string tencanho, float giacanho)
        {
            string querystring = "insert into canhochungcu values ( @tencanho , @giacanho , @tinhtrangcanho )";
            object[] para = { tencanho, giacanho, 0 }; //mặc định khi thêm tình trạng căn hộ là trống : 0
            return startExecuteNonquery(querystring, para);


        }
         
       
        public bool startXoaCanHo(int macanho)
        {
            
            if(quanLyDanCuController.startXoaDanCuTheoMaCanHo(macanho) != true) { //đầu tiên là phải xóa những dân cư đang ở căn hộ muốn xóa
                return false;
            }
            if (quanLyCongNoController.startXoaBienLaiThanhToan(macanho)!=true)
            {
                return false;
            }
            string querystring = "delete from canhochungcu where macanho = @macanho ";
            object[] para = { macanho };
            return startExecuteNonquery(querystring, para);
        }
        public bool startSuaCanHo(int macanho, string tencanho, float giacanho, int tinhtrangcanho)
        {
            string querystring = "update canhochungcu set tencanho= @tencanho , giacanho= @giacanho , tinhtrangcanho = @tinhtrangcanho where macanho = @macanho ";
            object[] para = { tencanho, giacanho, tinhtrangcanho, macanho };
            if(startExecuteNonquery(querystring, para) == true)
            {
                //sau khi thay đổi thành công, ta phải nghĩ đến việc là nếu căn hộ chuyển thành trống thì không có ai ở, lúc này ta mới bắt đầu xóa những
                //dữ liệu liên quan đến dân cư
                if (tinhtrangcanho == 0)
                { //nghĩa là trống => không ai ở => xóa toàn bộ dữ liệu liên quan đến căn hộ này            {

                    quanLyDanCuController.startXoaDanCu(macanho);

                }
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        public DataTable startTimKiemCanHo(int thongtin, object dulieuthongtin)
        {
            string[] arrConditionQuery =
            {
                "macanho = @macanho ",
                "tencanho = @tencanho ",
                "tinhtrangcanho = @tinhtrangcanho ",
                "giacanho <= @giacanho "
            };
            string querystring = "select * from canhochungcu where " + arrConditionQuery[thongtin];
            object[] para = { dulieuthongtin };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
    }
}
