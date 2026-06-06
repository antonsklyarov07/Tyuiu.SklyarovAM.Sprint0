using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SklyarovAM.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SklyarovAM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Антон";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Антон", res);
        }
    }
}
