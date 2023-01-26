using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireNotNullOrWhitespaceTests
    {
        [Fact]
        public void NotNullOrWhitespace_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotNullOrWhitespace(null, "name"));
        }

        [Fact]
        public void NotNullOrWhitespace_WhenEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.NotNullOrWhitespace("", "name"));
        }

        [Fact]
        public void NotNullOrWhitespace_WhenWhiteSpace_DoesNotThrow()
        {
            Assert.Throws<ArgumentException>(() => Require.NotNullOrWhitespace(" ", "name"));
        }

        [Fact]
        public void NotNullOrWhitespace_WhenNonWhiteSpace_DoesNotThrow()
        {
            Require.NotNullOrWhitespace("x", "name");
        }
    }
}
