using CRM.Application.Common.Constants;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.Auth
{
    public class AuthCommandValidator : AbstractValidator<AuthCommand>
    {
        public AuthCommandValidator()
        {
            RuleFor(p => p.Username)
                .NotEmpty().WithMessage(MessageConstants.FieldRequired);

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage(MessageConstants.FieldRequired);
        }
    }
}
