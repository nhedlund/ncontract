using System;
using System.Diagnostics;

namespace NContract
{
    [DebuggerStepThrough]
    public static class Require
    {
        public static void NotNull(object value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);
        }
    }
}
