using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sut22_XUnit_Övningar
{
    public class UserService
    {
        private List<User> users;
        public UserService()
        {
            users= new List<User>();
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public bool IsUserAdmin(string userName)
        {
            User us = users.FirstOrDefault(u => u.UserName == userName);
            return us?.IsAdmin ?? false;    
        }
    }
}
