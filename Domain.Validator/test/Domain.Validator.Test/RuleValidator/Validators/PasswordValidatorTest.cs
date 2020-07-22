using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class PasswordValidatorTest : ValidatorTestBase
    {
        public PasswordValidatorTest()
        {
            _errorMessage = "O campo {0} deve conter somente números.";
        }

        [Fact]
        public void Should_Be_Valid_Password()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).Password(true, true, true);
            _entity.Text = "Test@1";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Password_When_Doesnt_Have_Number_Char()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Password(true, false, false);
            _entity.Text = "Test@";
            _errorMessage = "O campo {0} deve conter pelo menos um número.";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Password_When_Doesnt_Have_UpperCase_Char()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Password(false, true, false);
            _entity.Text = "test@1";
            _errorMessage = "O campo {0} deve conter pelo menos uma letra maiúscula.";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Password_When_Doesnt_Have_SpecialChar()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Password(false, false, true);
            _entity.Text = "Test1";
            _errorMessage = "O campo {0} deve conter pelo menos um caracter especial.";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }
    }
}
