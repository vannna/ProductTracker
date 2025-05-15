using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackerApp.Models;

namespace ProductTrackerApp.Services
{
    public class UserService : IUserService
    {
        public User Login(string username, string password)
        {
            return DataStore.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            return DataStore.Users.ToList();
        }
    }
}

