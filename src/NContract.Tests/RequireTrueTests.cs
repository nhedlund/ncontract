using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireTrueTests
    {
        [Fact]
        public void True_WhenFalse_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Require.True(false, "name"));
            Assert.Throws<ArgumentException>(() => Require.True(false, "message", "name"));
            Assert.Throws<ApplicationException>(() => Require.True(false, () => new ApplicationException()));
        }

        [Fact]
        public void True_WhenTrue_DoesNotThrow()
        {
            Require.True(true, "name");
            Require.True(true, "message", "name");
            Require.True(true, () => new ApplicationException());
        }
    }
}
