using SocialLink.Domain.Assertion;

namespace SocialLink.Domain.ValueObjects
{
    public class Email
    {
        public readonly string Value;

        public Email(string email)
        {
            Value = email;
            Validate();
        }

        public override string ToString() => Value;

        private void Validate()
        {
            void ValidateLocal()
            {
                var exceptionMessage = "Email should have local.";
                if (Value.IndexOf("@") == -1) throw new DomainException(exceptionMessage);

                var local = Value.Substring(0, Value.IndexOf("@"));
                AssertConcern.AssetEqual(local.Length, 0, exceptionMessage);
            }

            void ValidateDomain()
            {
                var exceptionMessage = "Email should have a domain.";
                if (Value.IndexOf("@") == -1 || Value.LastIndexOf(".") == -1) throw new DomainException(exceptionMessage);

                var domain = Value.Substring(Value.IndexOf("@") + 1, Value.LastIndexOf(".") - Value.IndexOf("@") - 1);
                AssertConcern.AssetEqual(domain.Length, 0, exceptionMessage);
            }

            void ValidateTLD()
            {
                var exceptionMessage = "Email should have TLD.";
                if (Value.LastIndexOf(".") == -1) throw new DomainException(exceptionMessage);

                string TLD = Value.Substring(Value.LastIndexOf(".") + 1);
                AssertConcern.AssetEqual(TLD.Length, 0, exceptionMessage);
            }

            AssertConcern.AssetEqual(Value.Length, 0, "Invalid email.");
            ValidateLocal();
            ValidateDomain();
            ValidateTLD();
        }
    }
}