using Xunit;

namespace XunitTrx
{
    public class InlineDataTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void SingleParamTests(bool expected)
        {
            Assert.True(expected);
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void MultiParamTests(int a, int b)
        {
            Assert.Equal(a, b);
        }
    }
}