using curso_api.FIlters;
using curso_api.Models;
using curso_api.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;

namespace curso_api.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Authenticates a registered user
        /// </summary>
        /// <param name="login"></param>
        /// <returns>return state OK</returns>
        [SwaggerResponse(statusCode: 200, description: "Action successful", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Fields required", Type = typeof(CheckFieldsViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Internal error", Type = typeof(GenericErrorViewModel))]
        [HttpPost]
        [Route("login")]
        [CustomModelStateValidation]
        public IActionResult Login(LoginViewModelInput login)
        {           
            return Ok(login);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModelInput register)
        {
            return Created("", register);
        }
    }
}
