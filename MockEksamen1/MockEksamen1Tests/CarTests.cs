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
    public class CarTests
    {
        /// <summary>
        /// A test of car doors, where an argumentexception is thrown.
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarDoorReuirementsTestWithException()
        {
            //Arrange
            Car car = new Car(8,"Volkswagen","BN54865");
            //Act
            int door = car.DoorReuirements();
            //Assert
            Assert.AreEqual(8,door);
        }
        /// <summary>
        /// Test over car door, where we see if the door return 4 as in our new car.
        /// </summary>
        [TestMethod()]
        public void CarDoorReuirementsTest()
        {
            //Arrange
            Car car = new Car(4, "Volkswagen", "BN54865");
            //Act
            int door = car.DoorReuirements();
            //Assert
            Assert.AreEqual(4, door);
        }
        /// <summary>
        /// Test where car model is expected to throw an nullexception because model doesn't have anything in it.
        /// </summary>
        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void CarModelRequirementsTestWithException()
        {
            //Arrange
            Car car = new Car(5, null, "BN54865");
            //Act
            string model = car.ModelRequirements();
            //Assert
            Assert.AreEqual("Volkswagen", model);
        }
        /// <summary>
        /// Test to see if car model returns the expected string.
        /// </summary>
        [TestMethod()]
        public void CarModelRequirementsTest()
        {
            //Arrange
            Car car = new Car(5, "Volkswagen", "BN54865");
            //Act
            string model = car.ModelRequirements();
            //Assert
            Assert.AreEqual("Volkswagen", model);
        }
        /// <summary>
        /// Test if there is thrown an exception, when car registrationnumber is over 7 characters. 
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarRegistrationNoRequirementsTestWithExceptionOver()
        {
            //Arrange
            Car car = new Car(5, "Volkswagen", "BN5486549865468");
            //Act
            string RegistNo = car.RegistrationNoRequirements();
            //Assert
            Assert.AreEqual("BN5486",RegistNo);
        }
        /// <summary>
        /// Test if there is thrown an exception, when car registrationnumber is under 7 characters. 
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void CarRegistrationNoRequirementsTestWithExceptionUnder()
        {
            //Arrange
            Car car = new Car(5, "Volkswagen", "BN5486");
            //Act
            string RegistNo = car.RegistrationNoRequirements();
            //Assert
            Assert.AreEqual("BN5486", RegistNo);
        }
        /// <summary>
        /// Test where we see if car registrationnumber returns the expected string.
        /// </summary>
        [TestMethod()]
        public void CarRegistrationNoRequirementsTest()
        {
            //Arrange
            Car car = new Car(5, "Volkswagen", "BN54865");
            //Act
            string RegistNo = car.RegistrationNoRequirements();
            //Assert
            Assert.AreEqual("BN54865", RegistNo);
        }
 
    }
}