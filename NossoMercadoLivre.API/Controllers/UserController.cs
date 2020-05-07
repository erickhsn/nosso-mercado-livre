using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public ActionResult<User> NewUser([FromServices] IUserRepository userRepository, [FromBody] UserDTO userDTO)
        {
            var user = new User(userDTO.Login, userDTO.Password);
            userRepository.Insert(user);
            return Ok();
        }
    }
}
