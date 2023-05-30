using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut22_XUnit_Övningar
{
    public class EmailValidate
    {
        public bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
        public bool  IsValid(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}
