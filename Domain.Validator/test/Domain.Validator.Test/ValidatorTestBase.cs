using Domain.Validator.ArgumentValidator.RuleValidator;
using Domain.Validator.Interfaces;
using System.Linq;
using Xunit;

namespace Domain.Validator.Test
{
    public class ValidatorTestBase
    {
        protected IValidator<Entity> _validator;
        protected Entity _entity;
        protected string _errorMessage = "O campo {0} deve conter o valor maior ou igual que {1}.";
        protected string _fieldName;
        protected dynamic _fieldValue;

        public ValidatorTestBase()
        {
            _entity = new Entity();
            _validator = Validator<Entity>.New();
        }

        protected void ValidateErrorMessage(string _fieldName, dynamic _fieldValue)
        {
            var validatorResult = _validator.Validate(_entity);

            Assert.False(validatorResult.IsValid);
            Assert.NotEmpty(validatorResult.Errors);
            Assert.Equal(_fieldName, validatorResult.Errors.First().Property);
            Assert.Equal(string.Format(_errorMessage, _fieldName, _fieldValue), validatorResult.Errors.First().Messages.First());
        }

        protected void ValidateOkResult()
        {
            var result = _validator.Validate(_entity);

            Assert.True(result.IsValid);
        }
    }
}
