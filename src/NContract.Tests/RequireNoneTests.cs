using System;
using System.Linq;
using Xunit;

namespace NContract.Tests
{
    public class RequireNoneTests
    {
        [Fact]
        public void None_WhenEmpty_DoesNotThrow()
        {
            Require.None(Enumerable.Empty<int>(), v => v > 1, "message", "name");
        }

        [Fact]
        public void None_WhenDoesNotContainElementThatMatchesPredicate_DoesNotThrow()
        {
            Require.None(new[] {0, 1}, v => v > 1, "message", "name");
        }

        [Fact]
        public void None_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.None((int[]) null , v => v > 1, "message", "name"));
        }

        [Fact]
        public void None_WhenContainsElementThatMatchesPredicate_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.None(new[] { 1, 5 }, v => v > 1, "message", "name"));
        }
    }
}
