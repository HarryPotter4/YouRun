using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    class CalculatorOpTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveAndFour()
        {
            //Arrange
            CalulatorOp sut = new CalulatorOp();
            //Act
            int result = sut.add(5, 4);
            //Assert
            Assert.AreEqual(9, result);
        }

            [TestMethod]
        public void ShouldMulReturnTwentyWhenPassFiveAndFour()
        {
            //Arrange
            CalulatorOp sut = new CalulatorOp();
            //Act
            int result = sut.mul(5, 4);
            //Assert
            Assert.AreEqual(9, result);

        }
    }
}
