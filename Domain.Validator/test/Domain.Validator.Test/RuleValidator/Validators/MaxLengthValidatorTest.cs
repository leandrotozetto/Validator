using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class MaxLengthValidatorTest : ValidatorTestBase
    {
        public MaxLengthValidatorTest()
        {
            _errorMessage = "O campo {0} deve conter no máximo {1} caracteres.";
        }

        [Fact]
        public void Should_Be_Valid_String_When_Length_Is_Equal()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).MaxLength(13);
            _entity.Text = "test@test.com";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_String_When_Length_Is_Smaller()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).MaxLength(13);
            _entity.Text = "test@test.com";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_String_When_Length_Is_Greater()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).MaxLength(10);
            _entity.Text = "test.test.com";

            ValidateErrorMessage(_fieldName, 10);
        }
    }
}