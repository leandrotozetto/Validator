namespace Domain.Validator.Interfaces
{
    public interface IRule
    {
        void Validate(string fieldName, dynamic fieldValue);
    }
}
