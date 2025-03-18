using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] UserModel user)
        {
            _userService.SaveOrUpdateUser(user);
            return Ok(new { message = "Usuário criado com sucesso!" });
        }
    }
}