using Sut22_XUnit_Övningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_XUnit_Övningar_Testar
{
    public class StringHelpterTest
    {
        [Theory]
        [InlineData("hello","olleh")]
        [InlineData("world","dlrow")]
        [InlineData("","")]
        [InlineData("12345","54321")]
        [InlineData(null,null)]
        public void Reverse_ShouldReturnReverseString(string input,string expected)
        {
            //Arrange
            StringHelper stringhelper=new StringHelper();

            //Act
            string actualOutput=stringhelper.Reverse(input);

            //Assert
            Assert.Equal(expected, actualOutput);

        }
    }
}
