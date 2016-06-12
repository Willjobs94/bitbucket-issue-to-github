namespace BitbucketToGithub.Wrapper.Contracts
{
    public interface IConfigurationWrapper
    {
        string BitBucketKey { get; }
        string BitBucketSecret { get; }
        string GithubKey { get; }

        string GithubSecret { get; }
    }
}
