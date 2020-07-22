using Domain.Validator.Interfaces;
using System;

namespace Domain.Validator.ArgumentValidator.RuleValidator.Validators
{
    public class DateValidator<T> : IRule where T : class
    {
        private IRuleBuilder<T> _roleBuilder;

        private DateValidator() { }

        public static IRule New(IRuleBuilder<T> roleBuilder)
        {
            return new DateValidator<T>
            {
                _roleBuilder = roleBuilder
            };
        }

        public void Validate(string fieldName, dynamic fieldValue)
        {
            if (fieldValue != null)
            {
                DateTime date = DateTime.MinValue;
                bool isInvalid = false;

                switch (fieldValue.GetType())
                {
                    case Type x when (x == typeof(string)):
                        if (string.IsNullOrWhiteSpace(fieldValue) || DateTime.TryParse(fieldValue, out date) || IsDefaultValue(date))
                        {
                            isInvalid = true;
                        }
                        break;
                    case Type a when (a == typeof(DateTime) || a == typeof(DateTime?)):
                        if (fieldValue == null || IsDefaultValue(fieldValue))
                        {
                            isInvalid = true;
                        }
                        break;
                    default:
                        throw new Exception($"The type of the property {fieldName} isn't allowed in method Validation");
                }

                static bool IsDefaultValue(DateTime value)
                {
                    return value == DateTime.MinValue || value == DateTime.MaxValue;
                }

                if (isInvalid)
                {
                    _roleBuilder.AddErrorMessage(fieldName, RuleValidationMessage.Date(fieldName));
                }
            }
        }
    }
}
