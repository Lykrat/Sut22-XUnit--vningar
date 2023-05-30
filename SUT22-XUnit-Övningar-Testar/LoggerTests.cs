using Sut22_XUnit_Övningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_XUnit_Övningar_Testar
{
    public class LoggerTests
    {
        [Fact]
        public void LogMessage_ShouldAppendMessageToFile()
        {
            //Arrange
            string log = "test.log";
            LoggXUn logger=new LoggXUn(log);
            string message = "Test message";

            //Act
            logger.LogMessage(message);
            string[] lines = File.ReadAllLines(log);

            //Assert
            Assert.Contains(message, lines);

        }
    }
}
