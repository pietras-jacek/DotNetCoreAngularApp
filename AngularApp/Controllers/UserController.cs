using AngularApp.Models;
using AngularApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService service)
        {
            _userService = service;
        }
        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("user")]
        public async Task<ActionResult<IEnumerable<User>>> GetById(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateUser(User user)
        {
            await _userService.CreateUserAsync(user);
            return Ok(user);
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateUser(string id, User updatedUser)
        {
            var queriedUser = await _userService.GetUserByIdAsync(id);
            if (queriedUser == null)
            {
                return NotFound();
            }
            await _userService.UpdateUserAsync(id, updatedUser);
            return NoContent();
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            await _userService.DeleteUserAsync(id);
            return NoContent();
        }
    }
}
