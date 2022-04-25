using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.DataAccess.Abstract
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(string id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(string id); 
    }
}
