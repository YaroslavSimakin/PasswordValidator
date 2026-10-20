using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LabWork10;

namespace PasswordValidatorTests
{
    public class ValidatorTests
    {
        [Fact]
        public void Validate_ValidPassword_ReturnsTrue()
        {
            bool result = LabWork10.PasswordValidator.Validate("Admin123");
            Assert.True(result);
        }

        [Fact]
        public void Validate_LongValidPassword_ReturnsTrue()
        {
            bool result = LabWork10.PasswordValidator.Validate("VeryLongPassword0000");
            Assert.True(result);
        }

        [Fact]
        public void Validate_TooShortPassword_ReturnsFalse()
        {
            bool result = LabWork10.PasswordValidator.Validate("Short0");
            Assert.False(result);
        }

        [Fact]
        public void Validate_ContainsSpecialCharacters_ReturnsFalse()
        {
            bool result = LabWork10.PasswordValidator.Validate("Admin123!");
            Assert.False(result);
        }

        [Fact]
        public void Validate_ContainsCyrillic_ReturnsFalse()
        {
            bool result = LabWork10.PasswordValidator.Validate("Пароль123");
            Assert.False(result);
        }

        [Fact]
        public void Validate_EmptyPassword_ReturnsFalse()
        {
            bool result = LabWork10.PasswordValidator.Validate("");
            Assert.False(result);
        }
    }
}