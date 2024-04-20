using Moq;
using SearchNow.src.model.login_register_access;


namespace SearchNowAppTest.registerModelTest
{
    public class RegisterModelTests
    {
        private Mock<IRegisterModel> _registerModelMock;

        [SetUp]
        public void Setup()
        {
            _registerModelMock = new Mock<IRegisterModel>();
        }

        [Test]
        public void RegisterUser_ValidDetails_ReturnsTrue()
        {
            string username = "admin";
            string password = "Admin1";
            string email = "admin@example.com";
            string displayName = "Admin";
            string dateOfBirth = "1990-01-01";

            _registerModelMock.Setup(x => x.registerUser(username, password, email, displayName, dateOfBirth)).Returns(true);

            bool result = _registerModelMock.Object.registerUser(username, password, email, displayName, dateOfBirth);

            Assert.That(result, Is.True);
        }

        
    }
}
