using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class RequiredValidatorTest : ValidatorTestBase
    {
        public RequiredValidatorTest()
        {
            _errorMessage = "O campo {0} é obrigatório.";
        }

        [Fact]
        public void Should_Be_Valid_String()
        {
            _validator.RuleFor(x => x.Text, nameof(Entity.Text)).Required();
            _entity.Text = "Test@1";

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_String_Whenn_Is_Null()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Required();
            _entity.Text = string.Empty;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_String_Whenn_Is_WhiteSpace()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Required();
            _entity.Text = " ";

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_String_When_Is_Empty()
        {
            _fieldName = nameof(Entity.Text);
            _validator.RuleFor(x => x.Text, _fieldName).Required();
            _entity.Text = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Int32()
        {
            _validator.RuleFor(x => x.QuantityInt, nameof(Entity.QuantityInt)).Required();
            _entity.QuantityInt = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Int32_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityInt);
            _validator.RuleFor(x => x.QuantityInt, _fieldName).Required();
            _entity.QuantityInt = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Int32_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityInt);
            _validator.RuleFor(x => x.QuantityInt, _fieldName).Required();
            _entity.QuantityInt = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_UInt32()
        {
            _validator.RuleFor(x => x.QuantityUInt, nameof(Entity.QuantityUInt)).Required();
            _entity.QuantityUInt = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_UInt32_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityUInt);
            _validator.RuleFor(x => x.QuantityUInt, _fieldName).Required();
            _entity.QuantityInt = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_UInt32_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityUInt);
            _validator.RuleFor(x => x.QuantityUInt, _fieldName).Required();
            _entity.QuantityUInt = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Long()
        {
            _validator.RuleFor(x => x.QuantityLong, nameof(Entity.QuantityLong)).Required();
            _entity.QuantityLong = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Long_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityLong);
            _validator.RuleFor(x => x.QuantityLong, _fieldName).Required();
            _entity.QuantityLong = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Long_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityLong);
            _validator.RuleFor(x => x.QuantityLong, _fieldName).Required();
            _entity.QuantityLong = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_ULong()
        {
            _validator.RuleFor(x => x.QuantityUlong, nameof(Entity.QuantityUlong)).Required();
            _entity.QuantityUlong = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_ULong_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityUlong);
            _validator.RuleFor(x => x.QuantityLong, _fieldName).Required();
            _entity.QuantityUlong = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_ULong_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityUlong);
            _validator.RuleFor(x => x.QuantityUlong, _fieldName).Required();
            _entity.QuantityUlong = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Short()
        {
            _validator.RuleFor(x => x.QuantityShort, nameof(Entity.QuantityShort)).Required();
            _entity.QuantityShort = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Short_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityShort);
            _validator.RuleFor(x => x.QuantityShort, _fieldName).Required();
            _entity.QuantityShort = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Short_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityShort);
            _validator.RuleFor(x => x.QuantityShort, _fieldName).Required();
            _entity.QuantityShort = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_UShort()
        {
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantityUshort)).Required();
            _entity.QuantityUshort = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_UShort_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityUshort);
            _validator.RuleFor(x => x.QuantityUshort, _fieldName).Required();
            _entity.QuantityUshort = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_UShort_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityUshort);
            _validator.RuleFor(x => x.QuantityUshort, _fieldName).Required();
            _entity.QuantityUshort = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Double()
        {
            _validator.RuleFor(x => x.QuantityDouble, nameof(Entity.QuantityDouble)).Required();
            _entity.QuantityDouble = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Double_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityDouble);
            _validator.RuleFor(x => x.QuantityDouble, _fieldName).Required();
            _entity.QuantityDouble = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Double_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityDouble);
            _validator.RuleFor(x => x.QuantityDouble, _fieldName).Required();
            _entity.QuantityDouble = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Decimal()
        {
            _validator.RuleFor(x => x.QuantityDecimal, nameof(Entity.QuantityDecimal)).Required();
            _entity.QuantityDecimal = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Decimal_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityDecimal);
            _validator.RuleFor(x => x.QuantityDecimal, _fieldName).Required();
            _entity.QuantityDecimal = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Decimal_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantityDecimal);
            _validator.RuleFor(x => x.QuantityDecimal, _fieldName).Required();
            _entity.QuantityDecimal = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Byte()
        {
            _validator.RuleFor(x => x.QuantityByte, nameof(Entity.QuantityByte)).Required();
            _entity.QuantityByte = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Byte_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantityByte);
            _validator.RuleFor(x => x.QuantityByte, _fieldName).Required();
            _entity.QuantityByte = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Byte_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantitySbyte);
            _validator.RuleFor(x => x.QuantitySbyte, _fieldName).Required();
            _entity.QuantitySbyte = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_SByte()
        {
            _validator.RuleFor(x => x.QuantitySbyte, nameof(Entity.QuantitySbyte)).Required();
            _entity.QuantitySbyte = 1;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_SByte_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.QuantitySbyte);
            _validator.RuleFor(x => x.QuantitySbyte, _fieldName).Required();
            _entity.QuantitySbyte = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_SByte_When_Is_Null()
        {
            _fieldName = nameof(Entity.QuantitySbyte);
            _validator.RuleFor(x => x.QuantitySbyte, _fieldName).Required();
            _entity.QuantitySbyte = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Char()
        {
            _validator.RuleFor(x => x.Char, nameof(Entity.QuantitySbyte)).Required();
            _entity.Char = 'a';

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Char_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.Char);
            _validator.RuleFor(x => x.Char, _fieldName).Required();
            _entity.Char = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Char_When_Is_Null()
        {
            _fieldName = nameof(Entity.Char);
            _validator.RuleFor(x => x.Char, _fieldName).Required();
            _entity.Char = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Bool()
        {
            _validator.RuleFor(x => x.Bool, nameof(Entity.Bool)).Required();
            _entity.Bool = true;

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Bool_When_Is_Default_Value()
        {
            _fieldName = nameof(Entity.Bool);
            _validator.RuleFor(x => x.Bool, _fieldName).Required();
            _entity.Bool = default;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Invalid_Bool_When_Is_Null()
        {
            _fieldName = nameof(Entity.Bool);
            _validator.RuleFor(x => x.Bool, _fieldName).Required();
            _entity.Bool = null;

            ValidateErrorMessage(_fieldName, _fieldValue);
        }       
    }
}
