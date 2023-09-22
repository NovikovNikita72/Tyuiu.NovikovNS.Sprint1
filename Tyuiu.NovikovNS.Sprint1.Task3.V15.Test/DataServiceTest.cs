using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.NovikovNS.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 30;
            double v2 = 50;
            double S = 10;
            double T = 1;
            var res = ds.DistanceOverTime(v1, v2, S,T);
            Assert.AreEqual(90, res);
        }
    }
}
