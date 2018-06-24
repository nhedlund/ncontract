using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireNotNullOrEmptyTests
    {
        [Fact]
        public void NotNullOrEmpty_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotNullOrEmpty(null, "name"));
        }

        [Fact]
        public void NotNullOrEmpty_WhenEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.NotNullOrEmpty("", "name"));
        }

        [Fact]
        public void NotNullOrEmpty_WhenWhiteSpace_DoesNotThrow()
        {
            Require.NotNullOrEmpty(" ", "name");
        }
    }
}
