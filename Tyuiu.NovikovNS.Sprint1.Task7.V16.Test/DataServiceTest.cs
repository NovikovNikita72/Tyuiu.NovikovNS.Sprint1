using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.NovikovNS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = Math.Round(ds.Calculate(x),3);
            Assert.AreEqual(res,0,901);

        }
    }
}
