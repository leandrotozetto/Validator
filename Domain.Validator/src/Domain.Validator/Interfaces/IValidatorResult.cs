using Domain.Validator.RuleValidator;
using System.Collections.Generic;

namespace Domain.Validator.Interfaces
{
    public interface IValidatorResult
    {
        /// <summary>
        /// List with erros messages.
        /// </summary>
        IEnumerable<ValidationError> Errors { get; }

        bool IsValid { get; }
    }
}
