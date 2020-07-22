using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class NotNullValidatorTest : ValidatorTestBase
    {
        public NotNullValidatorTest()
        {
            _errorMessage = "O campo {0} não pode ser nulo.";
        }

        [Fact]
        public void Should_Be_Valid_Object_When_Object_Is_Not_Null()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).NotNull();
            _entity.Text = "test@test.com";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Object_When_Object_Is_Null()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).NotNull();
            _entity.Text = null;

            var result = _validator.Validate(_entity);

            ValidateErrorMessage(_fieldName, null);
        }

        [Fact]
        public void Should_Be_Valid_Object_When_Object_Is_String_Empty()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).NotNull();
            _entity.Text = string.Empty;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Object_When_Object_Is_Empty_Space()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).NotNull();
            _entity.Text = string.Empty;

            ValidateOkResult();
        }
    }
}
