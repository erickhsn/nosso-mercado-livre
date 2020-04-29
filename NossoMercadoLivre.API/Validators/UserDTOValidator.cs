using FluentValidation;
using NossoMercadoLivre.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NossoMercadoLivre.API.Validators
{
    public class UserDTOValidator : AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(u => u).
                NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentException("Objeto não encontrado!");
                });

            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("Usuario não pode ser nulo!")
                .EmailAddress().WithMessage("O usuario deve ter formato de email!");

            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("A senha não pode ser vazia!")
                .MinimumLength(6).WithMessage("A senha tem de ter mais do que 6 caracteres!");
        }
    }
}
