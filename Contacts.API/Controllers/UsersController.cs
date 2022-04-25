﻿using Contacts.Business.Abstract;
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

        public UsersController(IUserService userService)
        {
            _userService = userService;

        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var user = _userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }

        [HttpPost]
        public  IActionResult Post([FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                var createUSer = _userService.CreateUser(user);
                return CreatedAtAction("Get", new { id = createUSer.Id }, createUSer);

            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        public IActionResult Put([FromBody] User user)
        {
            if (_userService.GetUserById(user.Id) != null)
            {
                return Ok(_userService.UpdateUser(user));
            }
            return NotFound(); ;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            if (_userService.GetUserById(id) != null)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}
