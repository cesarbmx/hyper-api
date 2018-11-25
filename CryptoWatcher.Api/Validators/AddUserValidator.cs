﻿using CryptoWatcher.Api.Requests;
using CryptoWatcher.Domain.Messages;
using FluentValidation;

namespace CryptoWatcher.Api.Validators
{
    public class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserValidator()
        {
            RuleFor(x => x.UserId)
             .NotEmpty()
             .WithMessage(nameof(UserMessages.UserIdCannotBeEmpty) + " " + UserMessages.UserIdCannotBeEmpty);

        }
    }
}
