using System.IO;
using BitbucketToGithub.Core;
using BitbucketToGithub.Data;
using BitbucketToGithub.Data.Contracts;
using BitbucketToGithub.Utility;
using NUnit.Framework;

namespace BitBucketToGithub.Test
{
    [TestFixture]
    public class AccessTokenManagerTest
    {
        [SetUp]
        public void SetUp()
        {
            _sut = new AccessTokenManager();
        }

        private readonly AccessTokenMain _accessTokenMainTest = new AccessTokenMain
        {
            Bitbucket = new BitbucketAccessTokenResponse
            {
                Access_Token = "234rertert",
                Expires_In = "234234",
                Refresh_Token = "345345345",
                Scopes = "her ehrer herer",
                Token_type = "berear"
            },
            Github = new GithubAccessTokenResponse
            {
                Access_Token = "lskjflsjdlfjsdlfkf",
                Scope = "fskjsdjf sdjfsjd ",
                Token_type = "berear"
            }
        };

        [Test]
        public void ShouldReadJsonFile()
        {
            var accessTokenMain = _sut.GetAccessTokenMain(_jsonPath);

            Assert.That(accessTokenMain.Bitbucket.Access_Token, Is.EqualTo("234rertert"));
        }

        [Test]
        public void ShouldSaveToJson()
        {
            _sut.SaveChanges(_accessTokenMainTest, _jsonPath);
            Assert.That(_sut.GetAccessTokenMain(_jsonPath).Bitbucket.Access_Token, Is.EqualTo("234rertert"));
        }

        private IAccessTokenManager _sut;
        private readonly string _jsonPath = Path.Combine(new PathResolver().TestProject, "AccessTokenTest.json");

    }
}