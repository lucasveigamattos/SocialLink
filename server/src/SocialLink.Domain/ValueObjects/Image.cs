using SocialLink.Domain.Assertion;

namespace SocialLink.Domain.ValueObjects
{
    public class Image
    {
        public readonly string URI;

        public Image(string uri)
        {
            URI = uri;
            Validate();
        }

        public override string ToString() => URI;

        private void Validate()
        {
            AssertConcern.AssetEqual(URI.Length, 0, "Invalid URI.");
        }
    }
}