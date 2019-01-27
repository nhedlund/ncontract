using System;
using System.Linq;
using Xunit;

namespace NContract.Tests
{
    public class RequireAnyTests
    {
        [Fact]
        public void Any_WhenEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.Any(Enumerable.Empty<int>(), v => v > 1, "message", "name"));
        }

        [Fact]
        public void Any_WhenDoesNotContainElementThatMatchesPredicate_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.Any(new[] { 1 }, v => v > 1, "message", "name"));
        }

        [Fact]
        public void Any_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.Any((int[]) null , v => v > 1, "message", "name"));
        }

        [Fact]
        public void Any_WhenContainsElementThatMatchesPredicate_DoesNotThrow()
        {
            Require.Any(new[] { 1, 5 }, v => v > 1, "message", "name");
        }
    }
}
