using NossoMercadoLivre.Impl.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace NossoMercadoLivre.API.DTOs
{
    
    public class CategoryDTO
    {
        [Required(ErrorMessage = "O nome não pode ser nulo!")]
        [UniqueCategoryNameValidator(ErrorMessage = "Esta categoria já está cadastrada")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
    }
}
