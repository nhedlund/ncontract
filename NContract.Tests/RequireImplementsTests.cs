using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireImplementsTests
    {
        [Fact]
        public void Implements_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.Implements<string>(null, "name"));
        }

        [Fact]
        public void Implements_WhenImplemented_DoesNotThrow()
        {
            object value = new RequireTestClass();

            Require.Implements<IAmImplemented>(value, nameof(value));
        }

        [Fact]
        public void Implements_WhenImplemented_IsFast()
        {
            for (var i = 0; i < 1000000; i++)
            {
                object value = new RequireTestClass();
                Require.Implements<IAmImplemented>(value, nameof(value));
            }
        }

        [Fact]
        public void Implements_WhenIndirectlyImplemented_DoesNotThrow()
        {
            object value = new RequireTestClass();

            Require.Implements<IAmIndirectlyImplemented>(value, nameof(value));
        }

        [Fact]
        public void Implements_WhenNotImplemented_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.Implements<IAmNotImplemented>(new RequireTestClass(), "name"));
        }

        private interface IAmIndirectlyImplemented
        {
        }

        private interface IAmImplemented : IAmIndirectlyImplemented
        {
        }

        private interface IAmNotImplemented
        {
        }

        private class RequireTestClass : IAmImplemented
        {
        }
    }
}
