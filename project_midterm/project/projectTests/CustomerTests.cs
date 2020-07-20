using Microsoft.VisualStudio.TestTools.UnitTesting;
using project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void isValidEmailTest()
        {
            Customer test = new Customer();
            test.Email = "mohammad@gmail.com";

            Assert.AreEqual(true, test.isValidEmail());
        }

        [TestMethod()]
        public void IsPhoneNumber()
        {
            Customer test = new Customer();
            
            Assert.AreEqual(true, test.IsPhoneNumber("09100039730"));
        }

        [TestMethod()]
        public void checkNationalId()
        {
            Customer test = new Customer();

            Assert.AreEqual(true, test.checkNationalId("0024035432"));
        }

        [TestMethod()]
        public void IsValidPass()
        {
            Customer test = new Customer();

            Assert.AreEqual(true, test.IsValidPass("aA!1"));
        }

        [TestMethod()]
        public void IsValidName()
        {
            Customer test = new Customer();

            Assert.AreEqual(true, test.IsValidName("mohammad"));
        }
    }
}