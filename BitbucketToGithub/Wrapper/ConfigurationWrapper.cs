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

        public string GithubKey
            => ConfigurationManager.AppSettings["GithubKey"];

        public string GithubSecret
            => ConfigurationManager.AppSettings["GithubSecret"];
    }
}