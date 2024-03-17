using SocialLink.Domain.Aggregate;
using SocialLink.Domain.ValueObjects;
using Xunit;

namespace SocialLink.Domain.Tests.Aggregates
{
    public class UserTests
    {
        private User _user = new User(new Name("Name"), new Email("email@gmail.com"), new Image("uri"), new Bio(string.Empty), 0, 0);

        [Fact]
        public void CreateValidUser()
        {
            Assert.True(_user.Name.Value == "Name" && _user.Email.Value == "email@gmail.com" && _user.Picture.URI == "uri" && _user.Bio.Content == string.Empty && _user.LikesCount == 0 && _user.CommentsCount == 0);
        }

        [Fact]
        public void ChangeName()
        {
            _user.ChangeName(new Name("New Name"));
            Assert.Equal(_user.Name.Value, "New Name");
        }

        [Fact]
        public void ChangeEmail()
        {
            _user.ChangeEmail(new Email("newemail@gmail.com"));
            Assert.Equal(_user.Email.Value, "newemail@gmail.com");
        }

        [Fact]
        public void ChangePicture()
        {
            _user.ChangePicture(new Image("newuri"));
            Assert.Equal(_user.Picture.URI, "newuri");
        }

        [Fact]
        public void ChangeBio()
        {
            _user.ChangeBio(new Bio("new bio"));
            Assert.Equal(_user.Bio.Content, "new bio");
        }

        [Fact]
        public void Like()
        {
            var actual = _user.LikesCount + 1;
            _user.AddToLikesCount();

            Assert.Equal(_user.LikesCount, actual);
        }

        [Fact]
        public void RemoveLike()
        {
            var actual = _user.LikesCount - 1;
            _user.RemoveFromLikesCount();

            Assert.Equal(_user.LikesCount, actual);
        }

        [Fact]
        public void Comment()
        {
            var actual = _user.CommentsCount + 1;
            _user.AddToCommentsCount();

            Assert.Equal(_user.CommentsCount, actual);
        }

        [Fact]
        public void RemoveComment()
        {
            var actual = _user.CommentsCount - 1;
            _user.RemoveFromCommentsCount();

            Assert.Equal(_user.CommentsCount, actual);
        }
    }
}