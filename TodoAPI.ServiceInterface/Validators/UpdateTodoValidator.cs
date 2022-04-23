﻿using ServiceStack.FluentValidation;
using TodoAPI.DbModels;
using TodoAPI.ServiceModel;

namespace TodoAPI.ServiceInterface;
public class UpdateTodoValidator : AbstractValidator<UpdateTodo>
{
    public UpdateTodoValidator()
    {
        RuleFor(x => x.Description).NotEmpty().WithMessage("Description should not be empty.");
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title should not be empty.");
        RuleFor(x => x.ExpirationDate).NotEmpty().WithMessage("Expiration date should not be empty and in proper format.");
        RuleFor(x => x.PercentageOfCompleteness).NotEmpty().InclusiveBetween(0, 100).WithMessage("Percentage should not be empty and between 0 and 100.");
    }
}
