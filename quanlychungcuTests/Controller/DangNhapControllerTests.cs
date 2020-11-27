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
    public class DangNhapControllerTests
    {
        DangNhapController dangNhapController;
        [TestInitialize]
        public void Setup()
        {
            dangNhapController = new DangNhapController();
        }
        [TestMethod()]
        //kiểm tra xem nếu đăng nhập vào một tài khoản sai thì có trả về giá trị false hay không ?
        public void startLoginTest()
        {
            bool value = dangNhapController.startLogin("admin1", "123456");
            Assert.AreEqual(false,value);
        }
    }
}