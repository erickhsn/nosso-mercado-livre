using Microsoft.EntityFrameworkCore;
using Ninject;
using NossoMercadoLivre.Domain.Entities;
using NossoMercadoLivre.Domain.Interfaces.Repositories;
using NossoMercadoLivre.Impl.Context;
using NossoMercadoLivre.Impl.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace NossoMercadoLivre.Impl.Validator
{
    public class UniqueLoginValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userRepository = (IUserRepository)validationContext.GetService(typeof(IUserRepository)); 
            var user = userRepository.GetByLogin(value.ToString());
            return user != null ? new ValidationResult(FormatErrorMessage(validationContext.DisplayName)) : ValidationResult.Success;
        }
    }
}
