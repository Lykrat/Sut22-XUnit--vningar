using Sut22_XUnit_Övningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_XUnit_Övningar_Testar
{
    public class MathOperationTests
    {
        [Theory]
        [InlineData(2,3,6)]
        [InlineData(10,10,100)]
        [InlineData(-4,-5,20)]
        [InlineData(0,10,0)]
        [InlineData(7,0,7)]
        public void Multiply_ShouldReturnExpectedResult(int a,int b,int expected)
        {
            //Arrange
            MathOperation math = new MathOperation();
            //Act
            int actual=math.Multiply(a, b);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
