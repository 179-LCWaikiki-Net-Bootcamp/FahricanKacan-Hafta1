﻿using FluentValidation;
using Week1_Homework.Common;

namespace Week1_Homework.Application.TshirtOperations.Commands.Create
{
    public class CreateTshirtCommandValidator : AbstractValidator<CreateTshirViewModel>
    {
        public CreateTshirtCommandValidator()
        {

            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.Title).NotNull().MinimumLength(3);
            RuleFor(c => c.Color).IsInEnum();
            RuleFor(c => c.Category).NotNull().IsInEnum();
            RuleFor(c => c.Size).NotNull().IsInEnum();
                             
        }
    }
}
