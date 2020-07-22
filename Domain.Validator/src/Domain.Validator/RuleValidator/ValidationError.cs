using System.Collections.Generic;

namespace Domain.Validator.RuleValidator
{
    /// <summary>
     /// Represents a erros for entity od domain.
     /// </summary>
        public class ValidationError
    {
        /// <summary>
        /// Property namer has error.
        /// </summary>
        public string Property { get; set; }

        /// <summary>
        /// Message with especific error.
        /// </summary>
        public ICollection<string> Messages { get; set; }
    }
}