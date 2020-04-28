using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NossoMercadoLivre.Domain.DTOs
{
    [DataContract]
    public class UserDTO
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "login")]
        public string Login { get; set; }
        
        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
