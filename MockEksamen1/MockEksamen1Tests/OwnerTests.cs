using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamen1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen1.Tests
{
    [TestClass()]
    public class OwnerTests
    {
        /// <summary>
        /// A test that expect an exception, since Adress have to be more than 6 characters.
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void AddressRequirementTestWithException()
        {
            //Arrange
            Owner owner = new Owner("Bane", "Jacob", "31554334");
            //Act
            string address = owner.AddressRequirement();
            //Assert
            Assert.AreEqual("Bane", address);
        }
        /// <summary>
        /// Test if address return the string which is expected.
        /// </summary>
        [TestMethod()]
        public void AddressRequirementTest()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jacob", "31554334");
            //Act
            string address = owner.AddressRequirement();
            //Assert
            Assert.AreEqual("Banevej 3B", address);
        }
        /// <summary>
        /// Test that expect an exception, since the requirement for names needs to be more than 4 characters.
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void NameRequirementTestWithException()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jac", "31554334");
            //Act
            string name = owner.NameRequirement();
            //Assert
            Assert.AreEqual("Jac", name);
        }
        /// <summary>
        /// Test that make sure that our name returns the right string.
        /// </summary>
        [TestMethod()]
        public void NameRequirementTest()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jacob", "31554334");
            //Act
            string name = owner.NameRequirement();
            //Assert
            Assert.AreEqual("Jacob", name);
        }
        /// <summary>
        /// Test where we are expecting an exception since the phone requirement is 8 characters and the one in the test is 4 characters.
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void PhoneRequirementTestWithExceptionUnder()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jacob", "3155");
            //Act
            string phone = owner.PhoneRequirement();
            //Assert
            Assert.AreEqual("3155", phone);
        }
        /// <summary>
        /// Test if the method throw an exception when the phone number is higher than it is allowed(Required 8 exact and there is 10 characters).
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void PhoneRequirementTestWithExceptionOver()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jacob", "3155433485");
            //Act
            string phone = owner.PhoneRequirement();
            //Assert
            Assert.AreEqual("3155433485", phone);
        }
        /// <summary>
        /// Test if phone returns the right string.
        /// </summary>
        [TestMethod()]
        public void PhoneRequirementTest()
        {
            //Arrange
            Owner owner = new Owner("Banevej 3B", "Jacob", "31554334");
            //Act
            string phone = owner.PhoneRequirement();
            //Assert
            Assert.AreEqual("31554334", phone);
        }

    }
}