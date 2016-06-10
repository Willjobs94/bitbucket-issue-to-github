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

        [Test]
        public void ShouldGetBitBucketKey()
        {
            var sut = new ConfigurationWrapper();

            var key = sut.BitBucketKey;

            Assert.That(key, Is.EqualTo("BitBucketKey"));
        }

        [Test]
        public void ShouldGetBitBucketSecret()
        {

            var sut = new ConfigurationWrapper();

            var secret = sut.BitBucketSecret;

            Assert.That(secret, Is.EqualTo("BitBucketSecret"));
        }
    }
}
