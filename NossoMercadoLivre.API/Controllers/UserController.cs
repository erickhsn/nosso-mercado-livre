using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NossoMercadoLivre.APP.Validators;
using NossoMercadoLivre.Domain.DTOs;
using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Services;

namespace NossoMercadoLivre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public ActionResult<User> NewUser([FromServices] IUserService userService, [FromBody] UserDTO user)
        {
            UserDTOValidator validator = new UserDTOValidator();
            var validateResult = validator.Validate(user);
            if (validateResult.IsValid)
            {
                userService.CreateUser(user);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, validateResult);
            }

        }

    }
}
