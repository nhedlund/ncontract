using System;
using System.Collections;
using System.Diagnostics;

namespace NContract
{
    /// <summary>
    /// Require that parameter values follows certain conditions.
    /// </summary>
    [DebuggerStepThrough]
    public static class Require
    {
        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is true.
        /// </summary>
        /// <param name="condition">Condition to verify that must be true.</param>
        /// <param name="message">Exception message.</param>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="condition"/> parameter is false.</exception>
        public static void True(bool condition, string message)
        {
            if (!condition)
                throw new ArgumentException(message);
        }

        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is true.
        /// </summary>
        /// <param name="condition">Condition to verify that must be true.</param>
        /// <param name="message">Exception message.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="condition"/> parameter is false.</exception>
        public static void True(bool condition, string message, string parameterName)
        {
            if (!condition)
                throw new ArgumentException(message, parameterName);
        }

        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is true.
        /// </summary>
        /// <param name="condition">Condition to verify that must be true.</param>
        /// <param name="createException">Factory method that creates the exception thrown.</param>
        /// <exception cref="True{TException}">Thrown when the <paramref name="condition"/> parameter is false.</exception>
        public static void True<TException>(bool condition, Func<TException> createException) where TException : Exception
        {
            if (!condition)
                throw createException();
        }

        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is false.
        /// </summary>
        /// <param name="condition">Condition to verify that must be false.</param>
        /// <param name="message">Exception message.</param>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="condition"/> parameter is true.</exception>
        public static void False(bool condition, string message)
        {
            if (condition)
                throw new ArgumentException(message);
        }

        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is false.
        /// </summary>
        /// <param name="condition">Condition to verify that must be false.</param>
        /// <param name="message">Exception message.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="condition"/> parameter is true.</exception>
        public static void False(bool condition, string message, string parameterName)
        {
            if (condition)
                throw new ArgumentException(message, parameterName);
        }

        /// <summary>
        /// Require that the <paramref name="condition"/> parameter is false.
        /// </summary>
        /// <param name="condition">Condition to verify that must be false.</param>
        /// <param name="createException">Factory method that creates the exception thrown.</param>
        /// <exception cref="False{TException}">Thrown when the <paramref name="condition"/> parameter is true.</exception>
        public static void False<TException>(bool condition, Func<TException> createException) where TException : Exception
        {
            if (condition)
                throw createException();
        }

        /// <summary>
        /// Require that the <paramref name="value"/> parameter is not null.
        /// </summary>
        /// <param name="value">Value that must not be null.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="value"/> parameter is null.</exception>
        public static void NotNull(object value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Require that the <paramref name="value"/> parameter is null.
        /// </summary>
        /// <param name="value">Value that must be null.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="value"/> parameter is not null.</exception>
        public static void Null(object value, string parameterName)
        {
            if (value != null)
                throw new ArgumentException("Value must be null.", parameterName);
        }

        /// <summary>
        /// Require that the <paramref name="value"/> parameter is not null and not empty.
        /// </summary>
        /// <param name="value">Value that must not be null and not empty.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="value"/> parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the <paramref name="value"/> parameter is empty.</exception>
        public static void NotNullOrEmpty(string value, string parameterName)
        {
            if (!string.IsNullOrEmpty(value))
                return;

            if (value == null)
                throw new ArgumentNullException(parameterName);

            throw new ArgumentException("Value must not be empty.", parameterName);
        }

        /// <summary>
        /// Require that the <paramref name="value"/> parameter is not empty.
        /// </summary>
        /// <param name="value">Value that must be not be empty.</param>
        /// <param name="parameterName">Parameter name. Use <c>nameof(parameter)</c></param>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="value"/> parameter is empty.</exception>
        public static void NotEmpty(ICollection value, string parameterName)
        {
            if (value.Count == 0)
                throw new ArgumentException("Value must not be empty.", parameterName);
        }
    }
}
