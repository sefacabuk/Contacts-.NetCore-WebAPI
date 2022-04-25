using Contacts.Business.Abstract;
using Contacts.DataAccess.Abstract;
using Contacts.DataAccess.Concrete;
using Contacts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public  UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public void Delete(string id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(string id)
        {
            return _userRepository.GetUserById(id);

        }

        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);

        }
    }
}
