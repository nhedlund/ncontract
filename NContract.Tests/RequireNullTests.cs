using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireNullTests
    {
        [Fact]
        public void Null_WhenNull_DoesNotThrow()
        {
            Require.Null(null, "name");
        }

        [Fact]
        public void Null_WhenNotNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentException>(() => Require.Null("", "name"));
        }
    }
}
