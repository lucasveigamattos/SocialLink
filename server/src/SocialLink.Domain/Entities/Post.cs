namespace SocialLink.Domain.Entities
{
    public class Post : Entity
    {
        public Guid UserId { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Post> Comments { get; private set; }

        public Post(Guid userId, string content, int likes, List<Post> comments)
        {
            UserId = userId;
            Content = content;
            Likes = likes;
            Comments = comments;
        }

        public Post(Guid id, Guid userId, string content, int likes, List<Post> comments) : base(id)
        {
            UserId = userId;
            Content = content;
            Likes = likes;
            Comments = comments;
        }

        public void ChangeContent(string content)
        {
            Content = content;
        }

        public void Like()
        {
            Likes++;
        }

        public void Unlike()
        {
            Likes--;
        }

        public void PostComment(Post comment)
        {
            Comments.Add(comment);
        }

        public void DeleteComment(Guid commentId)
        {
            Post commentToBeDeleted = null;
            foreach(Post comment in Comments) if (comment.Id == commentId) commentToBeDeleted = comment;
            if (commentToBeDeleted is not null) Comments.Remove(commentToBeDeleted);
        }
    }
}