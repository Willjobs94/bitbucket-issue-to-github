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
        private Mock<IConfigurationWrapper> _configurationWrapper;

        [SetUp]
        public void SetUp()
        {
            _configurationWrapper = new Mock<IConfigurationWrapper>();
        }

        [Test]
        public void ShouldGetBitBucketKey()
        {
            var sut = new ConfigurationWrapper();

            var key = sut.BitBucketCredential.Key;

            Assert.That(key, Is.EqualTo("BitBucketKey"));
        }

        [Test]
        public void ShouldGetBitBucketSecret()
        {

            var sut = new ConfigurationWrapper();

            var secret = sut.BitBucketCredential.Secret;

            Assert.That(secret, Is.EqualTo("BitBucketSecret"));
        }
    }
}
