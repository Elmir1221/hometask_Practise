using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Model;

namespace ConsoleApp4.Service
{
    internal class UserService : User
    {

        public User[] GetAll()
        {
            User user1 = new User()
            {
                id = 1,
                fullName = "sdsad",
                password = "employee",
                email = "employee@gm.com",
                age = 31
            };
            User user2 = new User()
            {
                id = 2,
                fullName = "sdsad",
                password = "employee",
                email = "employee@gm.com",
                age = 31
            };
            User user3 = new User()
            {
                id = 3,
                fullName = "sdsad",
                password = "employee",
                email = "employee@gm.com",
                age = 31
            };
            User user4 = new User()
            {
                id = 4,
                fullName = "sdsad",
                password = "employee",
                email = "employee@gm.com",
                age = 31
            };

            User[] user = new User[] { user1, user2, user3, user4 };
            return user;
        }

        public User GetById(User[] users, int id)
        {
            return users.FirstOrDefault(m => m.id == id);
        }

        public int GetCountById(User[] users, int firstid, int lastid)
        {
            return users.Where(m => m.id > id && m.id == lastid).Count();
        }



    }
}
