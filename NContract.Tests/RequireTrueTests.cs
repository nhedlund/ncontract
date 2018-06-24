using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireTrueTests
    {
        [Fact]
        public void True_WhenFalse_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Require.True(false, "message", "name"));
        }

        [Fact]
        public void True_WhenTrue_DoesNotThrow()
        {
            Require.True(true, "message", "name");
        }
    }
}
