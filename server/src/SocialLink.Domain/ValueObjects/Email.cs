using SocialLink.Domain.Assertion;
using System.Security.Cryptography.X509Certificates;

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
                string local = Value.Substring(0, Value.IndexOf("@"));
                AssertConcern.AssetEqual(local.Length, 0, "Email should have local.");
            }

            void ValidateDomain()
            {
                string domain = Value.Substring(Value.IndexOf("@") + 1, Value.LastIndexOf(".") - Value.IndexOf(".") - 1);
                AssertConcern.AssetEqual(domain.Length, 0, "Email should have a domain.");
            }

            void ValidateTLD()
            {
                string TLD = Value.Substring(Value.IndexOf(".") + 1);
                AssertConcern.AssetEqual(TLD.Length, 0, "Email should have TLD.");
            }

            ValidateLocal();
            ValidateDomain();
            ValidateTLD();
        }
    }
}