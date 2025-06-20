using CinemaFriendly.Application.Users.Login;
using Microsoft.AspNetCore.Mvc;

namespace CinemaFriendly.Server.Controllers
{
    public class UserController(LoginUserHandler loginHandler) : Controller
    {
        private readonly LoginUserHandler _loginHandler = loginHandler;

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        {
            try
            {
                var token = await _loginHandler.HandleAsync(command);
                return Ok(new { token });
            }
            catch (InvalidOperationException ex)
            {
                return Unauthorized(new { error = ex.Message });
            }
        }

    }
}
