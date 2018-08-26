using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class UserGenerator
    {
        public static User LastGeneratedUser;

        public static void Initialize()
        {
            LastGeneratedUser = Generate();
        }

        public static User Generate()
        {
            var user = new User
            {
                //FullName = NameGenerator.Generate(),
                //MobileNumber = PhoneGenerator.Generate(),
                EmailAddress = "",
                Password = ""
            };

            LastGeneratedUser = user;
            return user;
        }
    }

    public class User
    {
        //public string FullName { get; set; }
        //public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}
