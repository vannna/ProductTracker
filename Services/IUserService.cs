using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackerApp.Models;

namespace ProductTrackerApp.Services
{
    public interface IUserService
    {
        User Login(string username, string password);
        List<User> GetAllUsers();
    }
}
