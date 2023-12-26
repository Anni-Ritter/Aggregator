using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator
{
    public class UserService
    {
        private static List<User> users = new List<User>
    {
        new User { Id = 1, Name = "User1" },
        new User { Id = 2, Name = "User2" },
        new User { Id = 3, Name = "User3" },
    };

        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(u => u.Id == userId);
        }
    }
}
