using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace CheckData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_For_Name_Input()
        {
            DataFeed data = new DataFeed();
            data.Name = "bandana";
            data.Id = 854;
            data.Address = "Viman Nagar";
            data.OfficeName = " Tavisca";

            Assert.AreEqual("bandana", data.Name);
        }

        [TestMethod]
        public void Test_For_Name_InputCases()
        {
            DataFeed data = new DataFeed();
            data.Name = "bandana";
            data.Id = 854;
            data.Address = "Viman Nagar";
            data.OfficeName = " Tavisca";

            Assert.AreNotEqual("Bandana", data.Name);
        }

        [TestMethod]
        public void Check_For_Values_Created()
        {
            DataList datalist = new DataList();
            DataFeed datafeed = new DataFeed();
            datafeed.Name = "Bandana";
            datafeed.Id = 854;
            datafeed.Address = "Viman Nagar";
            datafeed.OfficeName = "Tavisca";
            datalist.CreateData(datafeed);
            Assert.AreEqual(1, datalist.CountUser());
        }
    }
}
