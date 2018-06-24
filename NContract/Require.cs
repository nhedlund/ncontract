using System;
using System.Diagnostics;

namespace NContract
{
    [DebuggerStepThrough]
    public static class Require
    {
        public static void True(bool condition, string message, string parameterName)
        {
            if (!condition)
                throw new ArgumentException(message, parameterName);
        }

        public static void NotNull(object value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
        }

        public static void Null(object value, string parameterName)
        {
            if (value != null)
                throw new ArgumentException("Value must be null.", parameterName);
        }

        public static void NotNullOrEmpty(string value, string parameterName)
        {
            if (!string.IsNullOrEmpty(value))
                return;

            if (value == null)
                throw new ArgumentNullException(parameterName);

            throw new ArgumentException("Value must not be empty.", parameterName);
        }
    }
}
