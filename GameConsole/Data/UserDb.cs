using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserDb
    {
        private static List<User> users;



        public static User RegisterUser(string name, string userName, string password)
        {
            User newUser = new User(name, userName, password);
            users.Add(newUser);

            return newUser;
        }

        public static User Login(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.UserName == username && user.Password == password) { return user;  }
            }

            return null;
        }

        public static void Update(User u)
        {
            foreach (var user in users)
            {
                if (user.UserName == u.UserName) 
                { 
                    u.UserName = user.UserName; 
                    u.Password = user.Password;
                    return;
                }
            }

            throw new InvalidOperationException("no such user exists!");
        }
    }
}
