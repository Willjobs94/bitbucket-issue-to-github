using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Wrapper
{
    public class ConfigurationWrapper : IConfigurationWrapper
    {
        public IBaseCredential BitBucketCredential { get; } = new BitBucketCredential();
    }
}