using ConconcretoAPI.UserData;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace ConconcretoAPI.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserInterface _userInterface;
        public UsersController(UserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet]
        [Route("api/[controller")]
        public IActionResult GetUsers()
        {
            return Ok(_userInterface.GetUsers());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetUser(Guid id)
        {
            var user = _userInterface.GetUser(id);

            if ( user != null) { 
                return Ok(user);
            }
            return NotFound($"User with id: {id} not found");
        }


    }
}
