using CRM.Application.Common.Constants;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Application.User.Login
{
    public class LoginAccountCommandValidator : AbstractValidator<LoginAccountCommand>
    {

        public LoginAccountCommandValidator()
        {
            RuleFor(x => x.Account)
                .NotNull().WithMessage(MessageConstants.FieldRequired)
                .DependentRules(() =>
                {
                    RuleFor(x => x.Account.UserName)
                        .NotEmpty().WithMessage(MessageConstants.FieldRequired);

                    RuleFor(x => x.Account.PasswordHash)
                        .NotEmpty().WithMessage(MessageConstants.FieldRequired);
                });
        }
    }
}
