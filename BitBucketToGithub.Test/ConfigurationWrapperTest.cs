using BitbucketToGithub.Utility;
using BitbucketToGithub.Utility.Contracts;
using NUnit.Framework;

namespace BitBucketToGithub.Test
{
    [TestFixture]
    public class ConfigurationWrapperTest
    {
        [SetUp]
        public void SetUp()
        {
            _sut = new ConfigurationWrapper();
        }

        [Test]
        public void ShouldGetBitBucketKey()
        {
            var key = _sut.BitBucketKey;

            Assert.That(key, Is.EqualTo("BitBucketKey"));
        }

        [Test]
        public void ShouldGetBitBucketSecret()
        {
            var secret = _sut.BitBucketSecret;

            Assert.That(secret, Is.EqualTo("BitBucketSecret"));
        }

        [Test]
        public void ShouldGetGithubKey()
        {
            var key = _sut.GithubKey;
            Assert.That(key, Is.EqualTo("GithubKey"));
        }

        [Test]
        public void ShouldGetGithubSecret()
        {
            var secret = _sut.GithubSecret;
            Assert.That(secret, Is.EqualTo("GithubSecret"));
        }

        private IConfigurationWrapper _sut;
    }
}