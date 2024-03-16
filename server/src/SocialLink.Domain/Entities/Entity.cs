namespace SocialLink.Domain.Entities
{
    public class Entity
    {
        public readonly Guid Id;

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}