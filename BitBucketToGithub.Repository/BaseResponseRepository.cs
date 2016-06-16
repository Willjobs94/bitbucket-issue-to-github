using System.IO;
using BitbucketToGithub.Core;
using BitbucketToGithub.Data.Contracts;
using BitbucketToGithub.Utility.Contracts;
using BitBucketToGithub.Repository.Contracts;

namespace BitBucketToGithub.Repository
{
    public abstract class BaseResponseRepository : IBaseResponseRepository
    {
        protected BaseResponseRepository(IAccessTokenManager accessTokenManager, IPathResolver pathFinder)
        {
            _accessTokenManager = accessTokenManager;
            _jsonPath = Path.Combine(pathFinder.DataProject, "AccessToken.json");
            _accessTokenMain = accessTokenManager.GetAccessTokenMain(_jsonPath);
        }

        public void SaveChanges(BitbucketAccessTokenResponse bitbucketAccessTokenResponse)
        {
            _accessTokenMain.Bitbucket = bitbucketAccessTokenResponse;
            _accessTokenManager.SaveChanges(_accessTokenMain, _jsonPath);
        }

        public void SaveChanges(GithubAccessTokenResponse githubAccessTokenResponse)
        {
            _accessTokenMain.Github = githubAccessTokenResponse;
            _accessTokenManager.SaveChanges(_accessTokenMain, _jsonPath);
        }

        private readonly AccessTokenMain _accessTokenMain;
        private readonly IAccessTokenManager _accessTokenManager;
        private readonly string _jsonPath;
    }
}