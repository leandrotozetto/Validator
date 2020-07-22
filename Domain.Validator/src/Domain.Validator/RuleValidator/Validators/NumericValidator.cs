using Domain.Validator.Interfaces;
using System.Text.RegularExpressions;

namespace Domain.Validator.ArgumentValidator.RuleValidator.Validators
{
    public class NumericValidator<T> : IRule where T : class
    {
        private IRuleBuilder<T> _roleBuilder;

        private NumericValidator() { }

        public static IRule New(IRuleBuilder<T> roleBuilder)
        {
            return new NumericValidator<T>
            {
                _roleBuilder = roleBuilder
            };
        }

        public void Validate(string fieldName, dynamic fieldValue)
        {
            if (fieldValue != null)
            {
                var message = RuleValidationMessage.Numeric(fieldName);

                Regex regex = new Regex(@"^\d+$");

                if (!regex.IsMatch(fieldValue))
                {
                    _roleBuilder.AddErrorMessage(fieldName, message);
                }
            }
        }
    }
}
