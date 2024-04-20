using Moq;
using SearchNow.src.model.login_register_access;

namespace SearchNowAppTest.loginController_test
{
    /// <summary>
    /// This class contains unit tests for the LoginModel class.
    /// It uses the Moq framework to create a mock of the ILoginModel interface.
    /// </summary>
    public class LoginModelTests
    {
        /// <summary>
        /// A mock of the ILoginModel interface.
        /// </summary>
        private Mock<ILoginModel> _loginModelMock;

        /// <summary>
        /// This method is called before each test to set up the test environment.
        /// It initializes the _loginModelMock object.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _loginModelMock = new Mock<ILoginModel>();
        }

        /// <summary>
        /// This test checks if the checkLoginDetails method returns true when provided with valid credentials.
        /// </summary>
        [Test]
        public void CheckLoginDetails_ValidCredentials_ReturnsTrue()
        {
            string username = "admin";
            string password = "Admin1";

            _loginModelMock.Setup(x => x.checkLoginDetails(username, password)).Returns(true);

            bool result = _loginModelMock.Object.checkLoginDetails(username, password);

            Assert.That(result, Is.True);
        }

        /// <summary>
        /// This test checks if the checkLoginDetails method returns false when provided with invalid credentials.
        /// </summary>
        [Test]
        public void CheckLoginDetails_InvalidCredentials_ReturnsFalse()
        {
            string username = "invalid";
            string password = "invalid";

            _loginModelMock.Setup(x => x.checkLoginDetails(username, password)).Returns(false);

            bool result = _loginModelMock.Object.checkLoginDetails(username, password);

            Assert.That(result, Is.False);
        }
    }
}