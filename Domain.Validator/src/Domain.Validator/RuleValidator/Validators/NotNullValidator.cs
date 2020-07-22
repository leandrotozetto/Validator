﻿using Domain.Validator.Interfaces;

namespace Domain.Validator.ArgumentValidator.RuleValidator.Validators
{
    public class NotNullValidator<T> : IRule where T : class
    {
        private IRuleBuilder<T> _roleBuilder;

        private NotNullValidator() { }

        public static IRule New(IRuleBuilder<T> roleBuilder)
        {
            return new NotNullValidator<T>
            {
                _roleBuilder = roleBuilder
            };
        }

        public void Validate(string fieldName, dynamic fieldValue)
        {
            var isInvalid = false;
            var message = RuleValidationMessage.NotNull(fieldName);

            if (fieldValue is null)
            {
                isInvalid = true;
            }            

            if (isInvalid)
            {
                _roleBuilder.AddErrorMessage(fieldName, message);
            }
        }
    }
}
