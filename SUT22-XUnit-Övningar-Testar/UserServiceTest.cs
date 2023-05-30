using Sut22_XUnit_Övningar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT22_XUnit_Övningar_Testar
{
    public class UserServiceTest
    {
        [Fact]
        public void IsUserAdmin_ShouldReturnTrueForAdminUser()
        {
            //Arrange
            UserService userService = new UserService();

            User adminUser = new User { UserName = "admin", IsAdmin = true };
            User regularUser = new User { UserName = "user", IsAdmin = false };

            userService.AddUser(adminUser);
            userService.AddUser(regularUser);

            string adminUserName = "admin";
            string regularUserName = "user";

            //Act
            bool isAdminUser = userService.IsUserAdmin(adminUserName);
            bool isRegularUser = userService.IsUserAdmin(regularUserName);

            //Assert
            Assert.True(isAdminUser);
            Assert.False(isRegularUser);

        }
    }
}
