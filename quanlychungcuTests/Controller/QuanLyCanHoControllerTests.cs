using Microsoft.VisualStudio.TestTools.UnitTesting;
using quanlychungcu.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlychungcu.Controller.Tests
{
    [TestClass()]
    public class QuanLyCanHoControllerTests
    {
        QuanLyCanHoController quanLyCanHoController;
        [TestInitialize]
        public void Setup()
        {
            quanLyCanHoController = new QuanLyCanHoController();
        }
        //kiểm tra xem rằng khi thêm một căn hộ mới, nếu bỏ vào tên một căn hộ
        //đã tồn tại thì hàm Thêm Căn hộ có trả về giá trị false hay không 
        [TestMethod()]
        public void startThemCanHoTest()
        {
            bool valuetmp=quanLyCanHoController.startThemCanHo("P001", 50000000);
            Assert.AreEqual(false,valuetmp);
        }
    }
}