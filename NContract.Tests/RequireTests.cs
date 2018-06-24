using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireTests
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
            Require.NotNull(" ", "name");
        }

        [Fact]
        public void NotNullOrEmpty_WhenNotNull_DoesNotThrow()
        {
            Require.NotNull("", "name");
        }

    }
}
