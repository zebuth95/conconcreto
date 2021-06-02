using ConconcretoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConconcretoAPI.UserData
{
    public interface UserInterface
    {
        List<User> GetUsers();
        User GetUser(Guid id);
        User AddUser(User user);
        void DeleteUser(User user);
        User EditUser(User user);
    }
}
