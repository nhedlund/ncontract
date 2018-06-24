using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireNotNullTests
    {
        [Fact]
        public void NotNull_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotNull(null, "name"));
        }

        [Fact]
        public void NotNull_WhenNotNull_DoesNotThrow()
        {
            Require.NotNull("", "name");
        }
    }
}
