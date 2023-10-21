using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint2.Review.V7.Lib;

namespace Tyuiu.OsintsevKP.Sprint2.Review.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 2;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
