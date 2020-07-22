using Domain.Validator.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace Domain.Validator.ArgumentValidator.RuleValidator.Validators
{
    public class PasswordValidator<T> : IRule where T : class
    {
        private IRuleBuilder<T> _roleBuilder;

        private bool _hasNumber;

        private bool _hasUpperCase;

        private bool _hasSpecialChar;

        private PasswordValidator() { }

        public static IRule New(IRuleBuilder<T> roleBuilder, bool hasNumber, bool hasUpperCase, bool hasSpecialChar)
        {
            return new PasswordValidator<T>
            {
                _roleBuilder = roleBuilder,
                _hasNumber = hasNumber,
                _hasUpperCase = hasUpperCase,
                _hasSpecialChar = hasSpecialChar
            };
        }

        public void Validate(string fieldName, dynamic fieldValue)
        {
            if (fieldValue != null)
            {
                if (fieldValue.GetType() == typeof(string))
                {
                    var caracteres = ((string)fieldValue)?.ToArray();
                    var regex = new Regex("^[a-zA-Z0-9 ]*$");
                    var isNumber = false;
                    var isUpperCase = false;
                    var isSpecialChar = false;

                    foreach (var item in caracteres ?? new char[] { })
                    {
                        if (_hasNumber && !isNumber)
                        {
                            isNumber = char.IsDigit(item);
                        }

                        if (_hasUpperCase && !isUpperCase)
                        {
                            isUpperCase = char.IsUpper(item);
                        }

                        if (_hasSpecialChar && !isSpecialChar)
                        {
                            isSpecialChar = !regex.IsMatch(item.ToString());
                        }
                    }

                    if (_hasNumber && !isNumber)
                    {
                        _roleBuilder.AddErrorMessage(fieldName, RuleValidationMessage.PasswordNumericChar(fieldName));
                    }

                    if (_hasUpperCase && !isUpperCase)
                    {
                        _roleBuilder.AddErrorMessage(fieldName, RuleValidationMessage.PasswordUpperCaseChar(fieldName));
                    }

                    if (_hasSpecialChar && !isSpecialChar)
                    {
                        _roleBuilder.AddErrorMessage(fieldName, RuleValidationMessage.PasswordSpecialChar(fieldName));
                    }
                }
            }
        }
    }
}
