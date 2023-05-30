using Sut22_XUnit_Övningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_XUnit_Övningar_Testar
{
    public class EmailValidateTests
    {
        [Theory]
        [InlineData("test@example.com")]
        [InlineData("invalid_email")]
        [InlineData("")]
        [InlineData(null)]
        public void IsValidEmail_ShouldReturnExpectedResult(string email)
        {
            //Arrange
            EmailValidate emailValidate=new EmailValidate();

            bool expectedEmail = email?.Contains("@") ?? false;
            bool expectedResult = email.Contains("@") && email.Contains(".");
            //Act
            bool actualResult=emailValidate.IsValidEmail(email);
            bool actualRuselt2=emailValidate.IsValid(email);
            //Assert
            Assert.Equal(expectedEmail, actualResult);
            Assert.Equal(expectedResult, actualRuselt2);
        }
    }
}
