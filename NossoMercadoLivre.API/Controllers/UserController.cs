using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            try
            {
                var result = userService.CreateUser(user);

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
