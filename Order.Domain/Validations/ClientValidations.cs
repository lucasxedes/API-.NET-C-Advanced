using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Order.Domain.Models;

namespace Order.Domain.Validations
{
    public class ClientValidations : AbstractValidator<ClientModel>
    {
        public ClientValidations()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .Length(3,30);

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible);
                
            RuleFor(x => x.PhoneNumber)
                .NotNull()
                .NotEmpty();
        }
    }
}