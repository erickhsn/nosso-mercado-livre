using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NossoMercadoLivre.API.Validators;
using NossoMercadoLivre.Domain.DTOs;
using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;

namespace NossoMercadoLivre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpPost]
        public ActionResult<User> NewUser([FromServices] IUserRepository userRepository, [FromBody] UserDTO userDto)
        {
            UserDTOValidator validator = new UserDTOValidator();
            var validateResult = validator.Validate(userDto);
            if (validateResult.IsValid)
            {
                var passwordHash = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
                var user = new User(userDto.Login, passwordHash, DateTime.Now);
                userRepository.Insert(user);
                return Ok();
            }
            else
            {
                return BadRequest(validateResult);
            }

        }

    }
}
