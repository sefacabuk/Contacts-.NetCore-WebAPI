using Contacts.DataAccess.Abstract;
using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (var userDbContext = new ContactsDbContext())
            {
                userDbContext.Add(user);
                userDbContext.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(string id)
        {
            using (var userDbContext = new ContactsDbContext())
            {
                var deleteUser = GetUserById(id);
                userDbContext.Users.Remove(deleteUser);
                userDbContext.SaveChanges();
            }

            
        }

        public List<User> GetAllUsers()
        {
            using (var userDbContext = new ContactsDbContext())
            {
                return userDbContext.Users.ToList();
            }
        }

        public User GetUserById(string id)
        {
            using (var userDbContext = new ContactsDbContext())
            {
                return userDbContext.Users.Find(id);
            }
        }

        public User UpdateUser(User user)
        {
            using (var userDbContext = new ContactsDbContext())
            {
                userDbContext.Users.Update(user);
                userDbContext.SaveChanges();
                return user;
            }
        }
    }
}
