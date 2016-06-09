using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitbucketToGithub.Wrapper;
using BitbucketToGithub.Wrapper.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            _configurationWrapper.Setup(cm => cm.BitBucketCredential.Key).Returns("BitBucketKey");

            var key = _configurationWrapper.Object.BitBucketCredential.Key;

            Assert.That(key, Is.EqualTo("BitBucketKey"));
        }

        [Test]
        public void ShouldGetBitBucketSecret()
        {

            _configurationWrapper.Setup(cm => cm.BitBucketCredential.Secret).Returns("BitBucketSecret");

            var secret = _configurationWrapper.Object.BitBucketCredential.Secret;

            Assert.That(secret, Is.EqualTo("BitBucketSecret"));
        }

    }
}
