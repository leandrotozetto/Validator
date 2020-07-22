using Domain.Validator.ArgumentValidator.RuleValidator;
using System;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class DateValidatorTest : ValidatorTestBase
    {

        public DateValidatorTest()
        {
            _validator = Validator<Entity>.New(); _errorMessage = "O campo {0} deve conter uma data válida.";
        }

        [Fact]
        public void Should_Be_Valid_DateTime()
        {
            _validator.RuleFor(x => x.Birthdate, "Birthdate").Date();
            _entity.Birthdate = DateTime.Now;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_StringDateTime()
        {
            _validator.RuleFor(x => x.Birthday, nameof(_entity.Birthday)).Date();
            _entity.Birthdate = DateTime.Now;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_DateTime_When_Its_value_Is_Equals_DateTime_Min_Value()
        {
            _fieldName = nameof(_entity.Birthdate);
            _validator.RuleFor(x => x.Birthdate, _fieldName).Date();
            _entity.Birthdate = DateTime.MinValue;

            ValidateErrorMessage(_fieldName, _entity.Birthday);
        }

        [Fact]
        public void Should_Be_Invalid_DateTime_When_Its_value_Is_Equals_DateTime_Max_Value()
        {
            _fieldName = nameof(_entity.Birthdate);
            _validator.RuleFor(x => x.Birthdate, _fieldName).Date();
            _entity.Birthdate = DateTime.MaxValue;

            ValidateErrorMessage(_fieldName, _entity.Birthday);
        }

        [Fact]
        public void Should_Be_Invalid_StringDateTime_When_Its_value_Is_Equals_DateTime_Min_Value()
        {
            _fieldName = nameof(_entity.Birthday);
            _validator.RuleFor(x => x.Birthday, _fieldName).Date();
            _entity.Birthday = DateTime.MinValue.ToString();

            ValidateErrorMessage(_fieldName, _entity.Birthday);
        }

        [Fact]
        public void Should_Be_Invalid_StringDateTime_When_Its_value_Is_Equals_DateTime_Max_Value()
        {
            _fieldName = nameof(_entity.Birthday);
            _validator.RuleFor(x => x.Birthday, _fieldName).Date();
            _entity.Birthday = DateTime.MaxValue.ToString();

            ValidateErrorMessage(_fieldName, _entity.Birthday);
        }
    }
}
