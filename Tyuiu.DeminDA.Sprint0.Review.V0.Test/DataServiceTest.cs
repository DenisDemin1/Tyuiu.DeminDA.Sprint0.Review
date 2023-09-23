using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DeminDA.Sprint0.Review.V0.Lib;

namespace Tyuiu.DeminDA.Sprint0.Review.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int FirstNuber = 2;

            int SecondNumber = 3;

            int ThirdNumber = 4;

            int res = DataService.Calc(FirstNuber, SecondNumber, ThirdNumber);

            Assert.AreEqual(45, res);



        }
    }
}
