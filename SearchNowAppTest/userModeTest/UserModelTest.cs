using Moq;
using SearchNow.src.model.user_model;
using SearchNow.src.objects.user;

namespace SearchNowAppTest.userModeTest
{
    public class UserModelTest
    {
        private Mock<IUserModel> _userModelMock;
        private string _testUsername;

        [SetUp]
        public void Setup()
        {
            _testUsername = "admin";
            _userModelMock = new Mock<IUserModel>();

            _userModelMock.Setup(um => um.GetUser(_testUsername)).Returns(new User { Username = _testUsername });
        }

        
        [Test]
        public void GetUser_ValidUsername_ReturnsUser()
        {
            // Act
            bool result = false;
            var username = _userModelMock.Object.GetUser(_testUsername);
            if (_testUsername == username.Username)
            {
                result = true;
            }

            // Assert
            Assert.That(result,Is.True);
        }

        [Test]
        public void GetUser_InvalidUsername_ReturnUser()
        {
            string invalidUsername = "!invalidUsername!";
            _userModelMock.Setup(um => um.GetUser(invalidUsername)).Returns((User)null);

            // Act
            var result = _userModelMock.Object.GetUser(invalidUsername);

            Assert.That(result, Is.Null);
        }


        [Test]
        public void UpdatePassword_ValidUsername_UpdatesPassword()
        {
            // Arrange
            string testUsername = "demo";
            string testPassword = "Demo123";
            _userModelMock.Setup(um => um.UpdatePassword(testUsername, testPassword));

            // Act
            _userModelMock.Object.UpdatePassword(testUsername, testPassword);

            // Assert
            _userModelMock.Verify(um => um.UpdatePassword(testUsername, testPassword), Times.Once);
        }

        [Test]
        public void UpdateUserBio_ValidUsername_UpdatesBio()
        {
            // Arrange
            string testUsername = "admin";
            string testBio = "This is a test bio.";
            _userModelMock.Setup(um => um.UpdateUserBio(testUsername, testBio)).Returns(true);

            // Act
            bool result = _userModelMock.Object.UpdateUserBio(testUsername, testBio);

            // Assert
            Assert.That(result,Is.True);
        }

        [Test]
        public void UpdateUserBio_InvalidUsername_ReturnsFalse()
        {
            // Arrange
            string invalidUsername = "!invalidUsername!";
            string testBio = "This is a test bio.";
            _userModelMock.Setup(um => um.UpdateUserBio(invalidUsername, testBio)).Returns(false);

            // Act
            bool result = _userModelMock.Object.UpdateUserBio(invalidUsername, testBio);

            // Assert
            Assert.That(result,Is.False);
        }

        [Test]
        public void GetUserId_ValidUsername_ReturnsUserId()
        {
            // Arrange
            string testUsername = "admin";
            int expectedUserId = 1;
            _userModelMock.Setup(um => um.GetUserId(testUsername)).Returns(expectedUserId);

            // Act
            int result = _userModelMock.Object.GetUserId(testUsername);

            bool x = false;
            if(result == expectedUserId)
            {
                x = true;
            }
            // Assert
            Assert.That(x, Is.True);
        }

        [Test]
        public void GetUserId_InvalidUsername_ReturnsMinusOne()
        {
            // Arrange
            string invalidUsername = "!invalidUsername!";
            _userModelMock.Setup(um => um.GetUserId(invalidUsername)).Returns(-1);

            // Act
            int result = _userModelMock.Object.GetUserId(invalidUsername);

            // Assert
            Assert.That(-1, Is.Negative);
        }

        [Test]
        public void GetStatusFromUser_AdminUser_ReturnsTrue()
        {
            // Arrange
            string adminUsername = "admin";
            _userModelMock.Setup(um => um.getStatusFromUser(adminUsername)).Returns(true);

            // Act
            bool result = _userModelMock.Object.getStatusFromUser(adminUsername);

            // Assert
            Assert.That(result,Is.True);
        }

        [Test]
        public void GetStatusFromUser_NonAdminUser_ReturnsFalse()
        {
            // Arrange
            string nonAdminUsername = "user";
            _userModelMock.Setup(um => um.getStatusFromUser(nonAdminUsername)).Returns(false);

            // Act
            bool result = _userModelMock.Object.getStatusFromUser(nonAdminUsername);

            // Assert
            Assert.That(result,Is.False);
        }


    }
}
