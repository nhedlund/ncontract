using System;
using System.Linq;
using Xunit;

namespace NContract.Tests
{
    public class RequireAllTests
    {
        [Fact]
        public void All_WhenEmpty_DoesNotThrow()
        {
            Require.All(Enumerable.Empty<int>(), v => v > 1, "message", "name");
        }

        [Fact]
        public void All_WhenAllElementsMatchesPredicate_DoesNotThrow()
        {
            Require.All(new[] {2, 3}, v => v > 1, "message", "name");
        }

        [Fact]
        public void All_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.All((int[]) null , v => v > 1, "message", "name"));
        }

        [Fact]
        public void All_WhenContainsElementThatDoesNotMatchPredicate_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.All(new[] { 1, 5 }, v => v > 1, "message", "name"));
        }
    }
}
