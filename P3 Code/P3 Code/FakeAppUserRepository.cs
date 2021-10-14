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
                AppUsers.Add("BobbyJ", new AppUser
                {
                    UserName = "BobbyJ",
                    Password = "hi24",
                    FirstName = "Bob",
                    LastName = "John",
                    EmailAddress = "bobjohn@email.com",
                    isAuthenticated = false
                });
                AppUsers.Add("PaulC", new AppUser
                {
                    UserName = "PaulC",
                    Password = "password",
                    FirstName = "Paul",
                    LastName = "Carson",
                    EmailAddress = "paulcarson@email.com",
                    isAuthenticated = false
                });
            }
        }

        public bool Login(string UserName, string Password)
        {
            AppUser user;
            AppUsers.TryGetValue(UserName, out user);

            if (user != null && user.UserName == UserName && user.Password == Password) //username and password match
            {
                SetAuthentication(UserName, true);

                return true;
            }
            else
            {
                SetAuthentication(UserName, false);

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

            AppUser user;
            if (AppUsers.TryGetValue(UserName, out user) == true)
            {
                user.isAuthenticated = IsAuthenticated;
            }
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