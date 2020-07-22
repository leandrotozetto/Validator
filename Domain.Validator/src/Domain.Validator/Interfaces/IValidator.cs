﻿using System;
using System.Linq.Expressions;

namespace Domain.Validator.Interfaces
{
    public interface IValidator<T> where T : class
    {
        IRuleBuilder<T> RuleFor(Expression<Func<T, dynamic>> expressionProperty);

        IRuleBuilder<T> RuleFor(Expression<Func<T, dynamic>> expressionProperty, string customNameField);

        IValidatorResult Validate(T entity);
    }
}
