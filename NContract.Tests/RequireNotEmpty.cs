using System;
using System.Collections.Generic;
using Xunit;

namespace NContract.Tests
{
    public class RequireNotEmptyTests
    {
        [Fact]
        public void Array_WhenNotEmpty_DoesNotThrow()
        {
            Require.NotEmpty(new[] { 1 }, "name");
        }

        [Fact]
        public void Array_WhenEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.NotEmpty(new decimal[0], "name"));
        }

        [Fact]
        public void Array_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.NotEmpty(null, "name"));
        }

        [Fact]
        public void Dictionary_WhenNotEmpty_DoesNotThrow()
        {
            Require.NotEmpty(new Dictionary<int,string> { { 1, "x" } }, "name");
        }

        [Fact]
        public void Dictionary_WhenEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.NotEmpty(new Dictionary<int,string>(), "name"));
        }
    }
}
