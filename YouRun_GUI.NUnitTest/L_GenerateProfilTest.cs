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

        

        [Test]

        public void TestFuer5KmLauf()
        {
            //Arrange
            YouRun_GUI.Model.L_GenerateProfil testObj = new YouRun_GUI.Model.L_GenerateProfil();
            //Act
            double zeit=testObj.calcTimeForMarathonBasedOn5Km(20);
            //Assert 
            Assert.That(zeit, Is.EqualTo(195.96));
        }

        [Test]

        public void TestFuer10KmLauf()
        {
            //Arrange
            YouRun_GUI.Model.L_GenerateProfil testObj = new YouRun_GUI.Model.L_GenerateProfil();
            //Act
            double zeit = testObj.calcTimeForMarathonBasedOn10Km(60);
            //Assert 
            Assert.That(zeit, Is.EqualTo(280.02));
        }


    }

    
}
