using SocialLink.Domain.Assertion;
using SocialLink.Domain.ValueObjects;
using Xunit;

namespace SocialLink.Domain.Tests.ValueObjects
{
    public class NameTests
    {
        [Fact]
        public void ThrowExceptionWhenBlackName()
        {
            var exception = Assert.Throws<DomainException>(() => new Name(""));
            Assert.Equal(exception.Message, "Name can't be black.");
        }

        [Fact]
        public void ThrowExceptionWhenNameLengthMoreThan50Characters()
        {
            var exception = Assert.Throws<DomainException>(() => new Name("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.Equal(exception.Message, "Name can't have more than 50 characters.");
        }
    }
}
