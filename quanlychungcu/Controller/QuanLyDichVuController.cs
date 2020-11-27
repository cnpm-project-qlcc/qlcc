using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class QuanLyDichVuController
    {
        public QuanLyDichVuController()
        {

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
        public DataTable getListDichVu()
        {
            string querystring = "select * from dichvu";
            object[] para = {};
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public bool startThemDichVu(string tendichvu, float gia)
        {
            string querystring = "insert into dichvu values ( @tendichvu , @gia )";
            object[] para = { tendichvu, gia };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaSuDungDichVu(int madancu)
        {
            string querystring = "delete from sudungdichvu where madancu= @madancu ";
            object[] para = { madancu };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaSuDungDichVuTheoMaDichVu(int masodichvu)
        {
            string querystring = "delete from sudungdichvu where masodichvu= @masodichvu ";
            object[] para = { masodichvu };
            return startExecuteNonquery(querystring, para);
        }
        public bool startSuaDichVu(int masodichvu, string tendichvu, float gia)
        {
            string querystring = "update dichvu set tendichvu = @tendichvu , gia= @gia where masodichvu = @masodichvu ";
            object[] para = { tendichvu, gia, masodichvu };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaDichVu(int masodichvu)
        {
            //ta xóa dữ liệu bên sử dụng dịch vụ trước
            bool status = startXoaSuDungDichVuTheoMaDichVu(masodichvu);
            if(status == true)
            {
                string querystring = "delete from dichvu where masodichvu= @masodichvu ";
                object[] para = { masodichvu };
                return startExecuteNonquery(querystring, para);
            }
            else
            {
                return false;
            }
        }
        public DataTable startTimKiemDichVu(int thongtin, object dulieuthongtin)
        {
            string[] arrConditionQuery =
            {
                "masodichvu = @masodichvu ",
                "tendichvu = @tendichvu ",
                "gia <= @gia "
            };
            string querystring = "select * from dichvu where " + arrConditionQuery[thongtin];
            object[] para = { dulieuthongtin };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public DataTable getListDanCuSuDungDichVu()
        {
            string querystring1 = "select dv.masodichvu, dv.tendichvu, dv.gia, tmp1.madancu, tmp1.thoigiansudung from dichvu as dv inner join (";
            string querystring2 = " select * from sudungdichvu as sddv) as tmp1 on dv.masodichvu=tmp1.masodichvu";
            string querystring = querystring1 + querystring2;
            object[] para = { };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        
        public DataTable getListMaSoDichVu()
        {
            string querystring = "select masodichvu from dichvu";
            object[] para = { };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public bool startThemDanCuSuDungDichVu(int madancu, int masodichvu, string thoigiansudung)
        {
            string querystring = "insert into sudungdichvu values( @madancu , @masodichvu , @thoigiansudung )";
            object[] para = { madancu, masodichvu, thoigiansudung };
            return startExecuteNonquery(querystring, para);
        }
        public bool startSuaThongTinDanCuSuDungDichVu(int masodichvu, int madancu, string thoigiansudung, int oldmasodichvu, string oldngaysudung)
        {
                    
            string querystring = "update sudungdichvu set masodichvu = @masodichvu , thoigiansudung = @thoigiansudung where madancu= @madancu  and masodichvu = @oldmasodichvu and thoigiansudung = @oldngaysudung ";
            object[] para = { masodichvu, thoigiansudung, madancu, oldmasodichvu, oldngaysudung };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaDanCuSuDungDichVu(int masodichvu, int madancu,  string thoigiansudung)
        {
            string querystring = "delete from sudungdichvu where masodichvu= @masodichvu and madancu = @madancu and thoigiansudung = @thoigiansudung ";
            object[] para = { masodichvu, madancu, thoigiansudung };
            return startExecuteNonquery(querystring, para);
        }
        public DataTable startTimKiemDanCuSuDungDichVu(int kieuthongtin, object dulieuthongtin)
        {
            string[] arrConditionQuery =
            {
                "masodichvu = @masodichvu ",
                "madancu = @madancu ",
                "thoigiansudung = @thoigiansudung "
            };
            string querystring1 = "select dv.masodichvu, dv.tendichvu, dv.gia, tmp1.madancu, tmp1.thoigiansudung from dichvu as dv inner join (";
            string querystring2 = " select * from sudungdichvu as sddv where " + arrConditionQuery[kieuthongtin] +
                ") as tmp1 on dv.masodichvu=tmp1.masodichvu";
            string querystring = querystring1 + querystring2;
            object[] para = { dulieuthongtin };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
    }
    
}
