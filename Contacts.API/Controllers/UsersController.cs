using Contacts.Business.Abstract;
using Contacts.Business.Concrete;
using Contacts.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController()
        {
            _userService = new UserManager();

        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User Get(string id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public  User Post([FromBody] User user)
        {
            return _userService.CreateUser(user);

        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            return _userService.UpdateUser(user);
        }

        [HttpDelete]
        public void Delete(string id)
        {
            _userService.Delete(id);
        }
    }
}
