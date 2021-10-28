using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class TugasLibraryTest
    {
        private Day day;
        private User user;
        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();

        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual("Sabtu", day.NameOfDay(6));
        }
        [Test]
        public void IsValidUserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }

    }
}