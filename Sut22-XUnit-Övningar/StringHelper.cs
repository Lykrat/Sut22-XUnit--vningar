using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut22_XUnit_Övningar
{
    public class StringHelper
    {
        public string Reverse(string input)
        {
            char[] charArray=input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
