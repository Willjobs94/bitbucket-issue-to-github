using BitbucketToGithub.Wrapper;
using BitbucketToGithub.Wrapper.Contracts;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BitBucketToGithub.Test
{
    [TestFixture]
    public class ConfigurationWrapperTest
    {
        private ConfigurationWrapper sut;

        [SetUp]
        public void SetUp()
        {
            sut = new ConfigurationWrapper();
        }

        [Test]
        public void ShouldGetBitBucketKey()
        {
        
            var key = sut.BitBucketKey;

            Assert.That(key, Is.EqualTo("BitBucketKey"));
        }

        [Test]
        public void ShouldGetBitBucketSecret()
        {

            var secret = sut.BitBucketSecret;

            Assert.That(secret, Is.EqualTo("BitBucketSecret"));
        }

        [Test]
        public void ShouldGetGithubKey()
        {
            var key = sut.GithubKey;
            Assert.That(key, Is.EqualTo("GithubKey"));
        }

        [Test]
        public void ShouldGetGithubSecret()
        {
            var secret = sut.GithubSecret;
            Assert.That(secret, Is.EqualTo("GithubSecret"));
        }
    }

}
