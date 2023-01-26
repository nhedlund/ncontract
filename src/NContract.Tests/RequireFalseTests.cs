using System;
using Xunit;

namespace NContract.Tests
{
    public class RequireFalseTests
    {
        [Fact]
        public void False_WhenFalse_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Require.False(true, "name"));
            Assert.Throws<ArgumentException>(() => Require.False(true, "message", "name"));
            Assert.Throws<ApplicationException>(() => Require.False(true, () => new ApplicationException()));
        }

        [Fact]
        public void False_WhenTrue_DoesNotThrow()
        {
            Require.False(false, "name");
            Require.False(false, "message", "name");
            Require.False(false, () => new ApplicationException());
        }
    }
}
