using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint1.Task1.V1.Lib;

namespace Tyuiu.NovikovNS.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            double a = 1.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(7, res);
        }
    }
}
