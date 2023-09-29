using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint1.Task6.V7.Lib;
namespace Tyuiu.NovikovNS.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "Пример текста для тестирования";

          
            var res = ds.DeleteLastLetter(text);


            Assert.AreEqual("Приме текст дл тестировани", res);
        }
    }
}
