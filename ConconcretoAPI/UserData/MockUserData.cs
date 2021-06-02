using ConconcretoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConconcretoAPI.UserData
{
    public class MockUserData : UserInterface
    {
        private List<User> users = new List<User>()
        {
            new User()
            {
                Id = Guid.NewGuid(),
                Name = "User Name",
                LastName = "User LatName",
                Email= "user@gmail.com"
            },
            new User()
            {
                Id = Guid.NewGuid(),
                Name = "User Name 2",
                LastName = "User LatName 2",
                Email= "user2@gmail.com"
            }
        };
        public User AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            return users.SingleOrDefault(x => x.Id == id    );
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
