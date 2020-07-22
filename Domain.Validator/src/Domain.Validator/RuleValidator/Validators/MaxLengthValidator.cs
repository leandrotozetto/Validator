using Domain.Validator.Interfaces;

namespace Domain.Validator.ArgumentValidator.RuleValidator.Validators
{
    public class MaxLengthValidator<T> : IRule where T : class
    {
        private IRuleBuilder<T> _roleBuilder;

        private int _maxLength;

        private MaxLengthValidator() { }

        public static IRule New(IRuleBuilder<T> roleBuilder, int maxLength)
        {
            return new MaxLengthValidator<T>
            {
                _roleBuilder = roleBuilder,
                _maxLength = maxLength
            };
        }

        public void Validate(string fieldName, dynamic fieldValue)
        {
            if (fieldValue != null)
            {
                var message = RuleValidationMessage.MaxLength(fieldName, _maxLength);
                var isInvalid = false;

                if (fieldValue.GetType() == typeof(string))
                {
                    if (fieldValue == null || fieldValue.Length > _maxLength)
                    {
                        isInvalid = true;
                    }
                }

                if (isInvalid)
                {
                    _roleBuilder.AddErrorMessage(fieldName, message);
                }
            }
        }
    }
}
