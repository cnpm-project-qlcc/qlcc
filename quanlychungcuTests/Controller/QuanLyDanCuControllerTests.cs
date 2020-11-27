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
    public class QuanLyDanCuControllerTests
    {
        QuanLyDanCuController quanLyDanCuController;
        [TestInitialize]
        public void Setup()
        {
            quanLyDanCuController = new QuanLyDanCuController();
        }
        //kiểm tra xem rằng khi thêm thông tin dân cư, nếu đưa vào một mã căn hộ không tồn tại, thì hàm thêm dân cư
        //có trả về giá trị false hay không
        [TestMethod()]
        public void startThemDanCuTest()
        {
            object[] thongtindancu = { "Tô Thanh","Tín","18/05/2000",1,"272702833","0358551004","18/05/2019",44 };
            bool valuetmp=quanLyDanCuController.startThemDanCu(thongtindancu);
            Assert.AreEqual(false, valuetmp);
        }
    }
}