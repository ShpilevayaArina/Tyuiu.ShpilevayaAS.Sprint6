using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShpilevayaAS.Sprint6.Task7.V2.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint6\Tyuiu.ShpilevayaAS.Sprint6.Task7.V2\bin\Debug\InPutFileTask7V2.csv";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
