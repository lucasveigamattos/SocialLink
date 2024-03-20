namespace SocialLink.Domain.Entities
{
    public abstract class Entity
    {
        public readonly Guid Id;

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
        }
    }
}