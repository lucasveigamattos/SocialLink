namespace SocialLink.Domain.Assertion
{
    public static class AssertConcern
    {
        public static void AssetEqual(int value1, int value2, string message)
        {
            if (value1 == value2) throw new DomainException(message);
        }

        public static void AssertGratherThanOrEqualTo(int value1, int value2, string message)
        {
            if (value1 >= value2) throw new DomainException(message);
        }
    }
}