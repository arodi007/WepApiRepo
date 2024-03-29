using NUnit.Framework;
using WebAPI.Services;

namespace Tests
{
    public class Tests
    {
        private readonly ValidationService validationService;

        [SetUp]
        public void Setup()
        {
        }

        public Tests()
        {
            validationService = new ValidationService();
        }

        [Test]
        public void IsNumberShouldReturnFalseGivenAString()
        {
            var result = validationService.isNumber("abc");
            Assert.False(result, "abc should not be a number");
        }
    }
}