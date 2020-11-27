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
    public class DangKyControllerTests
    {
        DangKyController dangKyController;
        [TestInitialize]
        public void Setup()
        {
            dangKyController = new DangKyController();
        }
        //kiểm tra xem nếu đưa vào một tên tài khoản đã tồn tại thì hàm đăng ký có trả về giá trị false hay không ?
        [TestMethod()]
        public void startDangKyTest()
        {
            bool valuetmp = dangKyController.startDangKy("admin", "123456", "am");
            Assert.AreEqual(false, valuetmp);
        }
    }
}