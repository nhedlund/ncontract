using System;
using System.Collections.Generic;
using Xunit;

namespace NContract.Tests
{
    public class RequireEmptyTests
    {
        [Fact]
        public void Array_WhenEmpty_DoesNotThrow()
        {
            Require.Empty(new decimal[0], "name");
        }

        [Fact]
        public void Array_WhenNotEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.Empty(new[] { 1 }, "name"));
        }

        [Fact]
        public void Array_WhenNull_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Require.Empty(null, "name"));
        }

        [Fact]
        public void Dictionary_WhenEmpty_DoesNotThrow()
        {
            Require.Empty(new Dictionary<int,string>(), "name");
        }

        [Fact]
        public void Dictionary_WhenNotEmpty_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.Empty(new Dictionary<int,string> { { 1, "x" } }, "name"));
        }
    }
}
