using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NossoMercadoLivre.API.DTOs;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Impl.Entities;
using NossoMercadoLivre.Impl.Repository.Interfaces;

namespace NossoMercadoLivre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public ActionResult<Category> NewUser([FromServices] ICategoryRepository categoyRepository, [FromBody] CategoryDTO categoryDTO)
        {
            var category = new Category(categoryDTO.Name, categoryDTO.CategoryId);
            categoyRepository.Insert(category);
            return Ok();
        }
    }
}