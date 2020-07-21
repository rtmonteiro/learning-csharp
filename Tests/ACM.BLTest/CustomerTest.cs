using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTest
{
    [TestFixture]
    public class CustomerTest
    {
        [Test]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;
            
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void FullNameFistNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullName;
            
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullName;
            
            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void StaticTest()
        {
            //-- Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            Customer c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            Customer c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //-- Act
            
            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [Test]
        public void ValidateValid()
        {
            var customer = new Customer();
            
        }
    }
}