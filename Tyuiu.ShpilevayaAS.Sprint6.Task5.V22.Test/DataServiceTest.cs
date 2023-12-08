using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint6.Task5.V22.Lib;
using System.IO;

namespace Tyuiu.ShpilevayaAS.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        { 
            string path = @"C:\Users\katri\source\repos\Tyuiu.ShpilevayaAS.Sprint6\Tyuiu.ShpilevayaAS.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
