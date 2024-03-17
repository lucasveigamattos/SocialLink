using SocialLink.Domain.Assertion;
using SocialLink.Domain.ValueObjects;
using Xunit;

namespace SocialLink.Domain.Tests.ValueObjects
{
    public class BioTests
    {
        [Fact]
        public void ThrowExceptionWhenBioLengthMoreThan250()
        {
            var exception = Assert.Throws<DomainException>(() => new Bio("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.Equal(exception.Message, "Bio can't have more than 250 characters.");
        }
    }
}