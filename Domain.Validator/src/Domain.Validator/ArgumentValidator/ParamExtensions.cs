using Craftwork.Feedstock.Api.Domain.Core.Entities;
using System;

namespace Domain.Validator.ArgumentValidator
{
    /// <summary>
    /// Extensions that contains the methods to valid the arguments.
    /// </summary>
    public static class ParamExtensions
    {
        /// <summary>
        /// Checks if entity is not null.
        /// </summary>
        /// <typeparam name="T">argument's type.</typeparam>
        /// <param name="param">Data that will be validated.</param>
        public static void EntityIsNotNull<T>(this Param<T> param)
        {
            if (param._value == null)
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                //TODO: Resolve that
               // throw new DomainException(param._name, DomainMessage.EntityIsNull(param._name));
            }
        }

        /// <summary>
        /// Checks if arg is not null.
        /// </summary>
        /// <typeparam name="T">argument's type.</typeparam>
        /// <param name="param">Data that will be validated.</param>
        public static void ArgumentIsNotNull<T>(this Param<T> param)
        {
            if (param._value == null)
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                throw new ArgumentNullException(nameof(param._name));
            }
        }

        /// <summary>
        /// Checks if arg is not null.
        /// </summary>
        /// <param name="param">Data that will be validated.</param>
        public static void IsNullOrWhiteSpace(this Param<string> param)
        {
            if (string.IsNullOrWhiteSpace(param._value))
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                throw new ArgumentException(ValidatorMessage.IsNullOrWhiteSpace(nameof(param._name)));
            }
        }

        /// <summary>
        /// Checks is the entity is not null.
        /// </summary>
        /// <typeparam name="T">argument's type.</typeparam>
        /// <param name="param">Data that will be validated.</param>
        public static void EntityExists<T>(this Param<T> param)
        {
            if (param._value == null)
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                throw new Exception(ValidatorMessage.IdNotExist(param._name));
            }
        }

        /// <summary>
        /// Checks if the Guid is not empty
        /// </summary>
        /// <param name="param">Data that will be validated.</param>
        public static void IdNotEmpty(this Param<Guid> param)
        {
            if (param._value == Guid.Empty)
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                throw new Exception(ValidatorMessage.IdNotExist(param._name));
            }
        }

        /// <summary>
        /// Checks if the int is greather than zero
        /// </summary>
        /// <param name="param">Data that will be validated.</param>
        public static void HasValue(this Param<int> param)
        {
            if (param._value == 0)
            {
                if (param._customException != null)
                {
                    param._customException.Invoke();
                }

                throw new Exception(ValidatorMessage.IdNotExist(param._name));
            }
        }
    }
}
