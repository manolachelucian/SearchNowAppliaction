using Moq;
using SearchNow.src.model.validation_model;

namespace SearchNowAppTest.validationModel_test
{
    public class ValidationModelTests
    {
        private Mock<IValidationModel> _validationModelMock;

        [SetUp]
        public void Setup()
        {
            _validationModelMock = new Mock<IValidationModel>();
        }

        [Test]
        public void UsernameInUse_ExistingUsername_ReturnsTrue()
        {
            string username = "admin";

            _validationModelMock.Setup(x => x.usernameInUse(username)).Returns(true);

            bool result = _validationModelMock.Object.usernameInUse(username);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UsernameInUse_NonExistingUsername_ReturnsFalse()
        {
            string username = "karlito";

            _validationModelMock.Setup(x => x.usernameInUse(username)).Returns(false);

            bool result = _validationModelMock.Object.usernameInUse(username);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEmailAvailable_ExistingEmail_ReturnsFalse()
        {
            string email = "admin@admin.com";

            _validationModelMock.Setup(x => x.isEmailAvailable(email)).Returns(false);

            bool result = _validationModelMock.Object.isEmailAvailable(email);

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsEmailAvailable_NonExistingEmail_ReturnsTrue()
        {
            string email = "karlito123@seznam.cz";

            _validationModelMock.Setup(x => x.isEmailAvailable(email)).Returns(true);

            bool result = _validationModelMock.Object.isEmailAvailable(email);

            Assert.That(result, Is.True);
        }
    }
}
