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
    public class QuanLyDichVuControllerTests
    {
        QuanLyDichVuController quanLyDichVuController;
        [TestInitialize]
        public void Setup()
        {
            quanLyDichVuController = new QuanLyDichVuController();
        }
        [TestMethod()]
        public void startThemDichVuTest()
        {
            bool valuetmp=quanLyDichVuController.startThemDichVu("Gym", 'a');
            Assert.AreEqual(false,valuetmp);
        }
    }
}