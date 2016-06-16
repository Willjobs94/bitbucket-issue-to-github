using BitbucketToGithub.Data.Contracts;
using BitbucketToGithub.Utility.Contracts;
using BitBucketToGithub.Repository.Contracts;

namespace BitBucketToGithub.Repository
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GithubResponseRepository : BaseResponseRepository, IGithubResponseRepository
    {
        public GithubResponseRepository(IAccessTokenManager accessTokenManager, IPathResolver pathFinder)
            : base(accessTokenManager, pathFinder) { }
    }
}