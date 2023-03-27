using Xunit;

namespace SwaggerSourceGenerator.Tests
{
    public class SwaggerSourceGeneratorTests
    {
        [Fact]
        public void SwaggerSourceGeneratorTest()
        {
            var target = CreateTarget();

            var result = target.Execute();

            Assert.True(result);
        }

        private SwaggerSourceGenerator CreateTarget()
        {
            return new();
        }
    }
}
