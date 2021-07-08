using CORSWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORSWebAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUser(string id)
        {
            UserProfile user = new UserProfile() { Id = "TESTID", Name = "TEST NAME" };
            return Ok(user);
        }


        [HttpPost]
        public IActionResult CreateUser([FromBody] UserProfile user)
        {
            //Create user
            return StatusCode(201);
        }


        [HttpPut]
        public IActionResult UpdateUser([FromBody] UserProfile user)
        {
            //Update user
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(string id)
        {
            //Delete user
            return Ok();
        }

    }
}
