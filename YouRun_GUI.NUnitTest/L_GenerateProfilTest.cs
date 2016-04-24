using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace YouRun_GUI.NUnitTest
{
    [TestFixture]

    public class L_GenerateProfilTest
    {
        [Test]


        public void ichTrainiereNun22KmMehrProWoche()
        {
            //Arrange
            YouRun_GUI.Model.L_GenerateProfil testObj = new YouRun_GUI.Model.L_GenerateProfil();
            //Act
            testObj.calcTimeForSleep(22);
            //Assert 
            Assert.That(testObj.AdditionalDailySleep, Is.EqualTo(60));
        }

        //[Test]
    }
}
