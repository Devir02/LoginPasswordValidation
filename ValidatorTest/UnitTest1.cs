using NUnit.Framework;
using PasswordValidatorControl;
using PasswordValidatorControl.Services;
using PasswordValidatorControl.Model;
namespace PasswordValidatorControlTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ValidatePasswordTest10Characters_nonumbersfail()
        {
            string password = "ABCDEFghijkl";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest10Characters_nolettersfail()
        {
            string password = "1234567891";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest8Characters_numberstartsfail()
        {
            string password = "1BCDEFghi";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest8Characters_numberfinishesfail()
        {
            string password = "1BCDEFgh8";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest8Characters_nonumberfail()
        {
            string password = "abcdEFGH";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest8Characters_nouppercasefail()
        {
            string password = "abcdefgh";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest8Characters_nolowercasefail()
        {
            string password = "ABCDEFGH";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
        [Test]
        public void ValidatePasswordTest10Characters_pass()
        {
            string password = "1BCDEFghijkl";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult=validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success,true);
        }
        [Test]
        public void ValidatePasswordTest8Characters_pass()
        {
            string password = "aBCDF23g";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, true);
        }
        [Test]
        public void ValidatePasswordlessthan8Characters()
        {
            string password = "aBCD";
            ValidationResult validationResult = new ValidationResult();
            ICustomValidator validator = new CustomValidator();
            validationResult = validator.ValidatePassword(password);
            Assert.AreEqual(validationResult.Success, false);
        }
    }
}