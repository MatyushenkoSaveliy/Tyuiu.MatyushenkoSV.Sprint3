using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint3.Task1.V8.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double expected = -28.163;

            Assert.AreEqual(expected, res);
        }
    }
}