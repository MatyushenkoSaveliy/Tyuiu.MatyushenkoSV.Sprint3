using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint3.Task4.V8.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 2237.227;

            Assert.AreEqual(wait, res);
        }
    }
}