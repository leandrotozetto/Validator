using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class EmailValidatorTest : ValidatorTestBase
    {
        public EmailValidatorTest()
        {
            _errorMessage = "O campo Email deve conter um e-mail válido.";
        }

        [Fact]
        public void Should_Be_Valid_Email()
        {
            _validator.RuleFor(x => x.Email, nameof(Entity.Email)).Email();
            _entity.Email = "test@test.com";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Email()
        {
            _fieldName = nameof(Entity.Email);
            _validator.RuleFor(x => x.Email, _fieldName).Email();
            _entity.Email = "test.test.com";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }
    }
}
