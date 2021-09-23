using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using P3_Code;

namespace UnitTestFakeAppUserRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            // Arrange
            const String USERNAME = "PaulC";    // Valid username
            const String PASSWORD = "password";     // Valid password
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();

            // Act
            bool LoginReport = EmpRepository.Login(USERNAME, PASSWORD);

            //Assert
            Assert.IsTrue(LoginReport == true);
        }

        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            // Arrange
            const String USERNAME = "BobbyJ";    // Valid username
            const String PASSWORD = "hi244";     // Invalid password
            FakeAppUserRepository EmpRepository = new FakeAppUserRepository();

            // Act
            bool LoginReport = EmpRepository.Login(USERNAME, PASSWORD);

            //Assert
            Assert.IsFalse(LoginReport);
        }
    }
}
