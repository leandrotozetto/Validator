using Domain.Validator.ArgumentValidator.RuleValidator;
using System;
using System.Collections.Generic;

namespace Domain.Validator.Interfaces
{
    /// <summary>
    /// Interfae that defines method for validate entities.
    /// </summary>
    /// <typeparam name="T">Type os entity to be validated.</typeparam>
    public interface IPropertyValidation<T> : IDisposable
    {
        ICollection<IRule> Rules { get; }

        PropertyValues Compile(T entity);
    }
}
