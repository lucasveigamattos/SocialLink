using SocialLink.Domain.Assertion;
using SocialLink.Domain.ValueObjects;
using Xunit;

namespace SocialLink.Domain.Tests.ValueObjects
{
    public class ImageTests
    {
        [Fact]
        public void ThrowExceptionWhenInvalidURI()
        {
            var exception = Assert.Throws<DomainException>(() => new Image(""));
            Assert.Equal(exception.Message, "Invalid URI.");
        }
    }
}