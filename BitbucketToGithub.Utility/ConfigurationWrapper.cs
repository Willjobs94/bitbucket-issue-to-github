using System.Configuration;
using BitbucketToGithub.Utility.Contracts;

namespace BitbucketToGithub.Utility
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