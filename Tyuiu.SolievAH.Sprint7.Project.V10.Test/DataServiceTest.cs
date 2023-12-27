using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolievAH.Sprint7.Project.V10.Lib;

namespace Tyuiu.SolievAH.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService fidmax = new DataService();

            int[] costArray = new int[5] { 1, 2, 3, 4, 5 };

            int result = fidmax.FindMinPrice(costArray);
            int wait = 1;

            Assert.AreEqual(wait, result);
        }
    }
}
