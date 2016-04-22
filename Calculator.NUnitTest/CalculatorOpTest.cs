using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.NUnitTest
{
    [TestFixture]
    public class CalculatorOpTest
    {
        [Test]
        public void ShouldAddReturnNineWhenPassFiveAndFour()
        {
            //Arrange
            CalulatorOp sut = new CalulatorOp();
            //Act
            int result = sut.add(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void ShouldMulReturnTwentyWhenPassFiveAndFour()
        {
            //Arrange
            CalulatorOp sut = new CalulatorOp();
            //Act
            int result = sut.mul(5, 4);
            //Assert
            Assert.That(result, Is.EqualTo(20));

        }
    }
}
