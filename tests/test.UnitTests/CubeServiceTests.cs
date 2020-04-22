using Xunit;
using test.Services;

namespace test.Tests
{
    public class CubeServiceTests
    {
        [Fact]
        public void TestCube()
        {
            Assert.Equal(8, CubeService.Cube(2));
        }
    }
}
