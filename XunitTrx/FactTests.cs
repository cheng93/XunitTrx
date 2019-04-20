using Xunit;

namespace XunitTrx
{
    public class FactTests
    {
        // Wrong classname
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }
    }
}
