using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedCalculator;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class MathematicsTests
    {
        [TestMethod()]
        public void plusTest()
        {
            //arrange
            Mathematics TestMath = new Mathematics();
            //act
            double actual = TestMath.plus(2, 4);
            //assert'
            Assert.AreEqual(6, actual);
        }

        [TestMethod()]
        public void MinusTest()
        {
            //arrange
            Mathematics TestMath = new Mathematics();
            //act
            double actual = TestMath.Minus(4, 2);
            //assert'
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void MultiTest()
        {
            //arrange
            Mathematics TestMath = new Mathematics();
            //act
            double actual = TestMath.Multi(2, 4);
            //assert'
            Assert.AreEqual(8, actual);
        }

        [TestMethod()]
        public void DivideTest()
        {
            //arrange
            Mathematics TestMath = new Mathematics();
            //act
            double actual = TestMath.Divide(4, 2);
            //assert'
            Assert.AreEqual(2, actual);
        }

        [TestMethod()]
        public void iAndenTest()
        {
            //arrange
            Mathematics TestMath = new Mathematics();
            //act
            double actual = TestMath.iAnden(2);
            //assert'
            Assert.AreEqual(4, actual);
        }
    }
}