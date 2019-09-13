using NUnit.Framework;
using sorteio.models;

namespace sorteio.models.tests
{
    [TestFixture]
    public class PageRequestTest
    {
        [TestCase(1, 10)]
        public void Of_ShouldReturnPageNumber_ReturnsAnInteger(int number, int limit)
        {
            var pageRequest = PageRequest.First();
            var result = PageRequest.Of(number, limit);
            Assert.True(result.Limit == limit);
            // Assert.That(result, Is.InstanceOf(pageRequest));
        }
    }
}