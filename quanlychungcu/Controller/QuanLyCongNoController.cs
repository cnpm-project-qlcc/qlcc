using chungcu_demo1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller
{
    public class QuanLyCongNoController
    {
        
        public QuanLyCongNoController()
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
        public DataTable getListBienLaiThanhToan()
        {
            string querystring = "select * from bienlaithanhtoan";
            object[] para = { };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public bool startXoaBienLaiThanhToan(int macanho)
        {
            string querystring = "delete from bienlaithanhtoan where macanho = @macanho ";
            object[] para = { macanho };
            return startExecuteNonquery(querystring, para);
        }
        public bool startXoaBienLaiThanhToanTheoMaBienLai(int mabienlai)
        {
            string querystring= "delete from bienlaithanhtoan where mabienlai = @mabienlai ";
            object[] para = { mabienlai };
            return startExecuteNonquery(querystring, para);
        }
        public bool startSuaBienLaiThanhToan(int mabienlai, int tinhtrang)
        {
            string querystring = "update bienlaithanhtoan set tinhtrang = @tinhtrang where mabienlai = @mabienlai ";
            object[] para = { tinhtrang, mabienlai };
            return startExecuteNonquery(querystring, para);
        }
        public DataTable startTimKiemBienLaiThanhToan(int kieuthongtin, object thongtindulieu)
        {
            string[] arrConditionQuery =
            {
                " mabienlai = @mabienlai ",
                " macanho = @macanho ",
                " substring(thoigianlap,4,len(thoigianlap)) = @thoigianlap ",
                " tinhtrang = @tinhtrang ",
                " username = @username "
            };
            string querystring = "select * from bienlaithanhtoan where " + arrConditionQuery[kieuthongtin];
            object[] para = { thongtindulieu };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
        public object getPhiDichVuTheoThoiGianCuaCanHo(int macanho, string thoigianlap)
        {
            //lấy phí sử dụng dịch vụ của căn hộ theo thời gian lập biên lai và mã căn hộ
            string querystring = "select sum(dv.gia) from dichvu as dv inner join(select sddv.masodichvu as msdv1, sddv.madancu, tmp1.macanho as macanho1 from sudungdichvu as sddv inner join(select macanho, madancu from dancu where macanho = @macanho ) as tmp1 on tmp1.madancu = sddv.madancu where substring(thoigiansudung,4,len(thoigiansudung)) = @thoigianlap ) as tmp2 on tmp2.msdv1 = dv.masodichvu  group by(tmp2.macanho1) ";
            object[] para = { macanho, thoigianlap };
            return DataProvider.Instance.ExecuteScalar(querystring, para);
        }
        public bool startThemBienLai(float sotienthanhtoan, int macanho,string thoigianlap, int tinhtrang, string username)
        {
            string querystring = "insert into bienlaithanhtoan values( @sotienthanhtoan , @macanho , @thoigianlap , @tinhtrang , @username ) ";
            object[] para = { sotienthanhtoan, macanho, thoigianlap, tinhtrang, username };
            return startExecuteNonquery(querystring, para);
        }
        public object getPhiCanHo(int macanho)
        {
            string querystring = "select giacanho from canhochungcu where macanho = @macanho and ( tinhtrangcanho !=3 and tinhtrangcanho != 0  ) ";
            object[] para = { macanho };
            return DataProvider.Instance.ExecuteScalar(querystring, para);
        }
        public DataTable getListDanCuSuDungDichVu(int macanho, string thoigian)
        {
            string querystring = "select (dc.hovatenlot +' '+ dc.ten) as N'Họ và tên', tmp3.tdv as N'Tên dịch vụ', tmp3.tg2 as 'Thời gian sử dụng' from dancu as dc inner join (select dv.tendichvu as tdv, tmp2.mdc1 as mdc2, tmp2.tg1 as tg2 from dichvu as dv inner join(select sddv.masodichvu as msdv1, sddv.madancu as mdc1, tmp1.macanho as macanho1, sddv.thoigiansudung as tg1 from sudungdichvu as sddv inner join(select macanho, madancu from dancu where macanho = @macanho ) as tmp1 on tmp1.madancu = sddv.madancu where substring(thoigiansudung,4,len(thoigiansudung)) = @thoigian ) as tmp2 on tmp2.msdv1 = dv.masodichvu) as tmp3 on tmp3.mdc2 = dc.madancu";
            object[] para = { macanho, thoigian };
            return DataProvider.Instance.ExecuteQuery(querystring, para);
        }
    }
}
