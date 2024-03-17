using SocialLink.Domain.Assertion;
using SocialLink.Domain.ValueObjects;
using Xunit;

namespace SocialLink.Domain.Tests.ValueObjects
{
    public class EmailTests
    {
        [Fact]
        public  void ThrowExceptionWhenBlanckEmail()
        {
            var exception = Assert.Throws<DomainException>(() => new Email(""));
            Assert.Equal(exception.Message, "Invalid email.");
        }

        [Fact]
        public void ThrowExceptionWhenEmailDontHaveLocal()
        {
            var exception = Assert.Throws<DomainException>(() => new Email("@gmail.com"));
            Assert.Equal(exception.Message, "Email should have local.");
        }

        [Fact]
        public void ThrowExceptionWhenEmailDontHaveDomain()
        {
            var exception = Assert.Throws<DomainException>(() => new Email("email@.com"));
            Assert.Equal(exception.Message, "Email should have a domain.");
        }

        [Fact]
        public void ThrowExceptionWhenEmailDontHaveTLD()
        {
            var exception = Assert.Throws<DomainException>(() => new Email("email@gmail."));
            Assert.Equal(exception.Message, "Email should have TLD.");
        }
    }
}
