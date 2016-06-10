using System.Configuration;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Wrapper
{
    public class ConfigurationWrapper : IConfigurationWrapper
    {
        public string BitBucketKey 
            => ConfigurationManager.AppSettings["BitBucketKey"];

        public string BitBucketSecret
            => ConfigurationManager.AppSettings["BitBucketSecret"];
    }
}