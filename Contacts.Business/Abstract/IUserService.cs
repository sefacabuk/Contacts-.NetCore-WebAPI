using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Business.Abstract
{
   public interface IUserService
    {
        List<User> GetAllUsers();
        User GetUserById(string id);
        User CreateUser(User user);
        User UpdateUser(User user);
        void Delete(string id);

    }
}
