using SocialLink.Domain.Assertion;

namespace SocialLink.Domain.ValueObjects
{
    public class Bio
    {
        public readonly string Content;

        public Bio(string content)
        {
            Content = content;
            Validate();
        }

        private void Validate()
        {
            AssertConcern.AssertGratherThan(Content.Length, 250, "Bio can't have more than 250 characters.");
        }
    }
}