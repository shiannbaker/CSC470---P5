using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            // Arrange
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();
            // Act
            //Assert
        }
    }
}
