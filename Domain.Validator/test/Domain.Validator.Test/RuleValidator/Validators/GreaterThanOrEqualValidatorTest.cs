using Domain.Validator.ArgumentValidator.RuleValidator;
using Xunit;

namespace Domain.Validator.Test.RuleValidator.Validators
{
    public class GreaterThanOrEqualValidatorTest : ValidatorTestBase
    {
        public GreaterThanOrEqualValidatorTest()
        {
            _errorMessage = "O campo {0} deve conter o valor maior ou igual que {1}.";
        }

        [Fact]
        public void Should_Be_Valid_Int32_When_Values_Are_Equal()
        {
            _entity.QuantityInt = int.MaxValue;
            _validator.RuleFor(x => x.QuantityInt, _fieldName).GreaterThanOrEqual(_entity.QuantityInt);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Int32_When_Value_Is_Greater()
        {
            _entity.QuantityInt = int.MaxValue;
            _validator.RuleFor(x => x.QuantityInt, _fieldName).GreaterThanOrEqual(int.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Int32_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityInt);
            _fieldValue = int.MinValue;
            _entity.QuantityInt = _fieldValue;
            _validator.RuleFor(x => x.QuantityInt, _fieldName).GreaterThanOrEqual(int.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_UInt32_When_Values_Are_Equal()
        {
            _entity.QuantityUInt = uint.MaxValue;
            _validator.RuleFor(x => x.QuantityUInt, nameof(Entity.QuantityUInt)).GreaterThanOrEqual(_entity.QuantityUInt);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_UInt32_When_Value_Is_Greater()
        {
            _entity.QuantityUInt = uint.MaxValue;
            _validator.RuleFor(x => x.QuantityUInt, nameof(Entity.QuantityUInt)).GreaterThanOrEqual(uint.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_UInt32_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityUInt);
            _fieldValue = uint.MinValue;
            _entity.QuantityUInt = _fieldValue;
            _validator.RuleFor(x => x.QuantityUInt, _fieldName).GreaterThanOrEqual(uint.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Long_When_Values_Are_Equal()
        {
            _entity.QuantityLong = long.MaxValue;
            _validator.RuleFor(x => x.QuantityLong, nameof(Entity.QuantityLong)).GreaterThanOrEqual(_entity.QuantityLong);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Long_When_Value_Is_Greater()
        {
            _entity.QuantityUInt = int.MaxValue;
            _validator.RuleFor(x => x.QuantityLong, nameof(Entity.QuantityLong)).GreaterThanOrEqual(int.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Long_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityLong);
            _fieldValue = long.MinValue;
            _entity.QuantityLong = _fieldValue;

            _validator.RuleFor(x => x.QuantityLong, _fieldName).GreaterThanOrEqual(long.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_ULong_When_Values_Are_Equal()
        {
            _entity.QuantityUlong = ulong.MaxValue;
            _validator.RuleFor(x => x.QuantityUlong, nameof(Entity.QuantityUlong)).GreaterThanOrEqual(_entity.QuantityUlong);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_ULong_When_Value_Is_Greater()
        {
            _entity.QuantityUlong = ulong.MaxValue;
            _validator.RuleFor(x => x.QuantityUlong, nameof(Entity.QuantityLong)).GreaterThanOrEqual(ulong.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_ULong_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityUlong);
            _fieldValue = ulong.MinValue;
            _entity.QuantityUlong = _fieldValue;
            _validator.RuleFor(x => x.QuantityUlong, _fieldName).GreaterThanOrEqual(ulong.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Short_When_Values_Are_Equal()
        {
            _entity.QuantityShort = short.MaxValue;
            _validator.RuleFor(x => x.QuantityShort, nameof(Entity.QuantityShort)).GreaterThanOrEqual(_entity.QuantityShort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Short_When_Value_Is_Greater()
        {
            _entity.QuantityShort = short.MaxValue;
            _validator.RuleFor(x => x.QuantityShort, nameof(Entity.QuantityShort)).GreaterThanOrEqual(short.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Short_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityShort);
            _fieldValue = short.MinValue;
            _entity.QuantityShort = _fieldValue;
            _validator.RuleFor(x => x.QuantityShort, _fieldName).GreaterThanOrEqual(short.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_UShort_When_Values_Are_Equal()
        {
            _entity.QuantityUshort = ushort.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantityUshort)).GreaterThanOrEqual(_entity.QuantityUshort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_UShort_When_Value_Is_Greater()
        {
            _entity.QuantityUshort = ushort.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantityUshort)).GreaterThanOrEqual(short.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_UShort_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityUshort);
            _fieldValue = ushort.MinValue;
            _entity.QuantityUshort = _fieldValue;
            _validator.RuleFor(x => x.QuantityUshort, _fieldName).GreaterThanOrEqual(short.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Double_When_Values_Are_Equal()
        {
            _entity.QuantityDouble = double.MaxValue;
            _validator.RuleFor(x => x.QuantityDouble, nameof(Entity.QuantityDouble)).GreaterThanOrEqual(_entity.QuantityUshort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Double_When_Value_Is_Greater()
        {
            _entity.QuantityDouble = double.MaxValue;
            _validator.RuleFor(x => x.QuantityDouble, nameof(Entity.QuantityDouble)).GreaterThanOrEqual(double.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Double_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityDouble);
            _fieldValue = double.MinValue;
            _entity.QuantityDouble = _fieldValue;
            _validator.RuleFor(x => x.QuantityDouble, _fieldName).GreaterThanOrEqual(double.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Decimal_When_Values_Are_Equal()
        {
            _entity.QuantityDecimal = decimal.MaxValue;
            _validator.RuleFor(x => x.QuantityDecimal, nameof(Entity.QuantityDecimal)).GreaterThanOrEqual(_entity.QuantityUshort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Decimal_When_Value_Is_Greater()
        {
            _entity.QuantityDecimal = decimal.MaxValue;
            _validator.RuleFor(x => x.QuantityDecimal, nameof(Entity.QuantityDecimal)).GreaterThanOrEqual(decimal.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Decimal_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityDecimal);
            _fieldValue = decimal.MinValue;
            _entity.QuantityDecimal = _fieldValue;
            _validator.RuleFor(x => x.QuantityDecimal, _fieldName).GreaterThanOrEqual(decimal.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }
        [Fact]
        public void Should_Be_Invalid_Byte_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantityByte);
            _fieldValue = byte.MinValue;
            _entity.QuantityByte = _fieldValue;
            _validator.RuleFor(x => x.QuantityByte, _fieldName).GreaterThanOrEqual(byte.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Byte_When_Values_Are_Equal()
        {
            _entity.QuantityByte = byte.MaxValue;
            _validator.RuleFor(x => x.QuantityByte, nameof(Entity.QuantityByte)).GreaterThanOrEqual(_entity.QuantityUshort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Byte_When_Value_Is_Greater()
        {
            _entity.QuantityByte = byte.MaxValue;
            _validator.RuleFor(x => x.QuantityByte, nameof(Entity.QuantityByte)).GreaterThanOrEqual(byte.MinValue);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Invalid_Sbyte_When_Value_Is_Smaller()
        {
            _fieldName = nameof(Entity.QuantitySbyte);
            _fieldValue = sbyte.MinValue;
            _entity.QuantitySbyte = _fieldValue;
            _validator.RuleFor(x => x.QuantitySbyte, _fieldName).GreaterThanOrEqual(sbyte.MaxValue);

            ValidateErrorMessage(_fieldName, _fieldValue);
        }

        [Fact]
        public void Should_Be_Valid_Sbyte_When_Values_Are_Equal()
        {
            _entity.QuantitySbyte = sbyte.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantitySbyte)).GreaterThanOrEqual(_entity.QuantityUshort);

            ValidateOkResult();
        }

        [Fact]
        public void Should_Be_Valid_Sbyte_When_Value_Is_Greater()
        {
            _entity.QuantitySbyte = sbyte.MaxValue;
            _validator.RuleFor(x => x.QuantityUshort, nameof(Entity.QuantitySbyte)).GreaterThanOrEqual(byte.MinValue);

            ValidateOkResult();
        }
    }
}
