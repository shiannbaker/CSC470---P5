using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                //add some
                AppUsers.Add( "one" , new AppUser
                {
                    UserName = "BobbyJ",
                    Password = "hi24",
                    FirstName = "Bob",
                    LastName = "John",
                    EmailAddress = "bobjohn@email.com",
                    isAuthenticated = true
                });
                AppUsers.Add("two", new AppUser
                {
                    UserName = "PaulC",
                    Password = "password",
                    FirstName = "Paul",
                    LastName = "Carson",
                    EmailAddress = "paulcarson@email.com",
                    isAuthenticated = true
                });
            }
        }

        public bool Login(string UserName, string Password)
        {
            //return answer
            
        }

        public List<AppUser> GetAll()
        {
            //return all
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            //set authentication
        }

        public AppUser GetByUserName(string UserName)
        {
            //return result
        }
    }
}
