using BitbucketToGithub.Core;

namespace BitBucketToGithub.Repository.Contracts
{
    public interface IBaseResponseRepository
    {
        void SaveChanges(BitbucketAccessTokenResponse bitbucketAccessTokenResponse);

        void SaveChanges(GithubAccessTokenResponse githubAccessTokenResponse);
    }
}