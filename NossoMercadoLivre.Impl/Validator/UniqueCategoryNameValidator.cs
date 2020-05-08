using NossoMercadoLivre.Impl.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NossoMercadoLivre.Impl.Validator
{
    public class UniqueCategoryNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var userRepository = (ICategoryRepository)validationContext.GetService(typeof(ICategoryRepository));
            var user = userRepository.GetCategoryByName(value.ToString());
            return user != null ? new ValidationResult(FormatErrorMessage(validationContext.DisplayName)) : ValidationResult.Success;
        }
    }
}
