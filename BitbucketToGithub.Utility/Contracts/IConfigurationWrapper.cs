namespace BitbucketToGithub.Utility.Contracts
{
    public interface IConfigurationWrapper
    {
        /// <summary>
        ///     Rpresents the BitBucket public key
        /// </summary>
        string BitBucketKey { get; }

        /// <summary>
        ///     Rpresents the BitBucket secret key
        /// </summary>
        string BitBucketSecret { get; }

        /// <summary>
        ///     Represents the Github public key
        /// </summary>
        string GithubKey { get; }

        /// <summary>
        ///     Represents the Github secrete key
        /// </summary>
        string GithubSecret { get; }
    }
}