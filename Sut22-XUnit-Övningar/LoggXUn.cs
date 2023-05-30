using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut22_XUnit_Övningar
{
    public class LoggXUn
    {
        private string _logProfile;

        public LoggXUn(string logProfile)
        {
            _logProfile = logProfile;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
