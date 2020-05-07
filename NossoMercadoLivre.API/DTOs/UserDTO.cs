using NossoMercadoLivre.Impl.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace NossoMercadoLivre.Domain.DTOs
{
    [DataContract]
    public class UserDTO
    {
      
        [Required(ErrorMessage = "Usuario não pode ser nulo!")]
        [EmailAddress(ErrorMessage = "O usuario deve ter formato de email!")]
        [UniqueLoginValidator(ErrorMessage = "O login já está sendo usado!")]
        [DataMember(Name = "login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha não pode ser vazia!")]
        [MinLength(6, ErrorMessage = "A senha tem de ter mais do que 6 caracteres!")]
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
