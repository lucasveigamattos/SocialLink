using SocialLink.Domain.Entities;
using Xunit;

namespace SocialLink.Domain.Tests.Entities
{
    public class PostTests
    {
        private Post _post = new Post(Guid.NewGuid(), "Test Post.", 0, new List<Post>());

        [Fact]
        public void ChangeContent()
        {
            _post.ChangeContent("New Content.");
            Assert.Equal(_post.Content, "New Content.");
        }

        [Fact]
        public void Like()
        {
            var actual = _post.Likes + 1;
            _post.Like();

            Assert.Equal(_post.Likes, actual);
        }

        [Fact]
        public void Unlike()
        {
            var actual = _post.Likes - 1;
            _post.Unlike();

            Assert.Equal(_post.Likes, actual);
        }

        [Fact]
        public void Comment()
        {
            _post.PostComment(new Post(Guid.NewGuid(), "Test Comment.", 0, new List<Post>()));
            var comment = _post.Comments[0];

            Assert.True(comment.Id != null && comment.UserId != null && comment.Content == "Test Comment." && comment.Likes == 0 && comment.Comments.Count == 0);
        }

        [Fact]
        public void DeleteComment()
        {
            _post.PostComment(new Post(Guid.NewGuid(), "Test Comment.", 0, new List<Post>()));
            _post.DeleteComment(_post.Comments[0].Id);

            Assert.Equal(_post.Comments.Count, 0);
        } 
    }
}