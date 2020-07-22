using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class GreaterThanValidatorTest : ValidatorTestBase
    {
        public GreaterThanValidatorTest()
        {
            _errorMessage = "O campo {0} deve conter o valor maior que {1}.";
        }

        [Fact]
        public void Should_Be_Valid_Int32_When_Value_Is_Greater()
        {
            _entity.QuantityInt = int.MaxValue;
            _validator.RuleFor(x => x.QuantityInt, _fieldName).GreaterThan(int.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_UInt32_When_Value_Is_Greater()
        {
            _entity.QuantityUInt = uint.MaxValue;
            _validator.RuleFor(x => x.QuantityUInt, nameof(Entity.QuantityUInt)).GreaterThan(uint.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Long_When_Value_Is_Greater()
        {
            _validator.RuleFor(x => x.QuantityLong, nameof(Entity.QuantityLong)).GreaterThan(int.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_ULong_When_Value_Is_Greater()
        {
            _entity.QuantityUlong = ulong.MaxValue;
            _validator.RuleFor(x => x.QuantityUlong, nameof(Entity.QuantityLong)).GreaterThan(ulong.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Short_When_Value_Is_Greater()
        {
            _entity.QuantityShort = short.MaxValue;
            _validator.RuleFor(x => x.QuantityShort, nameof(Entity.QuantityShort)).GreaterThan(short.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_UShort_When_Value_Is_Greater()
        {
            _entity.QuantityUshort = ushort.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantityUshort)).GreaterThan(short.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Double_When_Value_Is_Greater()
        {
            _entity.QuantityDouble = double.MaxValue;
            _validator.RuleFor(x => x.QuantityDouble, nameof(Entity.QuantityDouble)).GreaterThan(double.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Decimal_When_Value_Is_Greater()
        {
            _entity.QuantityDecimal = decimal.MaxValue;
            _validator.RuleFor(x => x.QuantityDecimal, nameof(Entity.QuantityDecimal)).GreaterThan(decimal.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Byte_When_Value_Is_Greater()
        {
            _entity.QuantityByte = byte.MaxValue;
            _validator.RuleFor(x => x.QuantityByte, nameof(Entity.QuantityByte)).GreaterThan(byte.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Sbyte_When_Value_Is_Greater()
        {
            _entity.QuantitySbyte = sbyte.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantitySbyte)).GreaterThan(sbyte.MinValue);

            ValidateOkResult();
        }
    }
}
