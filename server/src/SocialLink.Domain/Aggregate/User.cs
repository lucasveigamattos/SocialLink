using SocialLink.Domain.Entities;
using SocialLink.Domain.ValueObjects;

namespace SocialLink.Domain.Aggregate
{
    public class User : Entity, IAggregateRoot
    {
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public Image Picture { get; private set; }
        public Bio Bio { get; private set; }
        public int LikesCount { get; private set; }
        public int CommentsCount { get; private set; }

        public User(Name name, Email email, Image picture, Bio bio, int likesCount, int commentsCount)
        {
            Name = name;
            Email = email;
            Picture = picture;
            Bio = bio;
            LikesCount = likesCount;
            CommentsCount = commentsCount;
        }

        public void ChangeName(Name name)
        {
            Name = name;
        }

        public void ChangeEmail(Email email)
        {
            Email = email;
        }

        public void ChangePicture(Image picture)
        {
            Picture = picture;
        }

        public void ChangeBio(Bio bio)
        {
            Bio = bio;
        }

        public void AddToLikesCount()
        {
            LikesCount++;
        }

        public void RemoveFromLikesCount()
        {
            LikesCount--;
        }

        public void AddToCommentsCount()
        {
            CommentsCount++;
        }

        public void RemoveFromCommentsCount()
        {
            CommentsCount--;
        }
    }
}