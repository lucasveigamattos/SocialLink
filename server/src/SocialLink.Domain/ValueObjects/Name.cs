using SocialLink.Domain.Assertion;

namespace SocialLink.Domain.ValueObjects
{
    public class Name
    {
        public readonly string Value;

        public Name(string name)
        {
            Value = name;
            Validate();
        }

        public override string ToString() => Value;

        private void Validate()
        {
            AssertConcern.AssetEqual(Value.Length, 0, "Name can't be black.");
            AssertConcern.AssertGratherThanOrEqualTo(Value.Length, 50, "Name can't have more than 50 characters.");
        }
    }
}