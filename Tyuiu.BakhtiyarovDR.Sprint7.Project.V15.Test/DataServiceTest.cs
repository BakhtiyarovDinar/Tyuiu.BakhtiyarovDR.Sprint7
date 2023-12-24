using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint7.Project.V15.Lib;
namespace Tyuiu.BakhtiyarovDR.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSumm()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Dinar\Desktop\Task7.csv";
            int res = ds.Sum(path);
            int wait = 50000;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCount()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Dinar\Desktop\Task7.csv";
            int res = ds.Count(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidSrednee()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Dinar\Desktop\Task7.csv";
            double res = ds.Srednee(path);
            double wait = 16666.7;
            Assert.AreEqual(wait, res);
        }
    }
}
