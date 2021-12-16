using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MailValidator.Tests
{
    public class MailValidatorShould
    {
        [Fact]
        public void ValidateValidEmails()
        {
            // Arrange
            var mailValidator = new MailValidator();
            string email = "asasa@asasa.tv";
            // Act
            bool isValid = mailValidator.IsValidEmail(email);
            // Assert
            Assert.True(isValid, $"{email} no es un email válido. Revisa el email.");
        }
        [Fact]
        public void InvalidateInvalidEmails()
        {
            // Arrange
            var mailValidator = new MailValidator();
            string email = "asasa@asasa.z";
            // Act
            bool isValid = mailValidator.IsValidEmail(email);
            // Assert
            Assert.False(isValid);
        }
        [Theory]
        [InlineData("string", false)]
        [InlineData("mail@mail.mo", true)]
        public void ValidateEmail(string email, bool expected)
        {
            // Arrange
            var mailValidator = new MailValidator();
            // Act
            bool actual = mailValidator.IsValidEmail(email);
            // Assert
            Assert.Equal(expected, actual);
            // PRIMERO pasamos expected como parámetro
        }
        [Theory]
        [InlineData("myspam@gmail.com", "INBOX")]
        [InlineData("sdadadsa@goodspam.com", "SPAM")]
        public void IdentifySpam(string email, string expected)
        {
            // Arrange
            var mailValidator = new MailValidator();
            // Act
            string actual = mailValidator.IsSpam(email);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
