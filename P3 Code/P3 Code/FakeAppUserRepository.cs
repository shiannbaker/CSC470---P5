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

        public FakeAppUserRepository() //i set the usernames to be the key values
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                //add some
                AppUsers.Add( "BobbyJ" , new AppUser
                {
                    UserName = "BobbyJ",
                    Password = "hi24",
                    FirstName = "Bob",
                    LastName = "John",
                    EmailAddress = "bobjohn@email.com",
                    isAuthenticated = true
                });
                AppUsers.Add("PaulC", new AppUser
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
            AppUser user;
            if (AppUsers.TryGetValue(UserName, out user) && AppUsers.TryGetValue(Password, out user)) //username and password match
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<AppUser> GetAll()
        {
            //return all
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            return users;
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            //set authentication
            
        }

        public AppUser GetByUserName(string UserName)
        {
            //return result
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            return user;
        }
    }
}
