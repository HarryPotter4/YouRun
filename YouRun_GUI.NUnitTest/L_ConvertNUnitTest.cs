using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace YouRun_GUI.NUnitTest
{
    [TestFixture]

    public class L_ConvertNUnitTest
    {
        [Test]


        public void minConvertTest()
        { 
            //Arrange
            var testObj = new YouRun_GUI.Model.L_Convert();
            //Act
            testObj.convertMinToHourAndMin(200);
            //Assert 
            Assert.That(testObj.min, Is.EqualTo(20));
        }
    }
    


}

    