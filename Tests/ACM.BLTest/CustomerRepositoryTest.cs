using System;
using ACM.BL;
using NUnit.Framework;

namespace ACM.BLTest
{
  [TestFixture]
  public class CustomerRepositoryTest
  {
    [Test]
    public void RetrieveValid()
    {
      //-- Arrange
      var customerRepository = new CustomerRepository();
      var expected = new Customer(1)
      {
        EmailAddress = "fbaggins@hobbiton.me",
        FirstName = "Frodo",
        LastName = "Baggins"
      };

      //-- Act
      var actual = customerRepository.Retrieve(1);

      //-- Assert
      Assert.AreEqual(expected.CustomerId, actual.CustomerId);
      Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
      Assert.AreEqual(expected.FirstName, actual.FirstName);
      Assert.AreEqual(expected.LastName, actual.LastName);
    }
  }
}
