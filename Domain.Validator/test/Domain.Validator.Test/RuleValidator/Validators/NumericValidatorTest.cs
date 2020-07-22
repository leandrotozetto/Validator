using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class NumericValidatorTest : ValidatorTestBase
    {
        public NumericValidatorTest()
        {
            _errorMessage = "O campo {0} deve conter somente números.";
        }

        [Fact]
        public void Should_Be_Valid_Number()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).Numeric();
            _entity.Text = "12";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Number()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Numeric();
            _entity.Text = "10B";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }
    }
}
