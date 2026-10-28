using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint3.Task3.V16.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "ice nice ice creamcc";
            char chr = 'c';

            int res = ds.GetCharCount(str, chr);

            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}