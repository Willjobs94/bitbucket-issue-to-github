using BitbucketToGithub.Data.Contracts;
using BitbucketToGithub.Utility.Contracts;
using BitBucketToGithub.Repository.Contracts;

namespace BitBucketToGithub.Repository
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BitbucketResponseRepository : BaseResponseRepository, IBitbucketResponseRepository
    {
        public BitbucketResponseRepository(IAccessTokenManager accessTokenManager, IPathResolver pathFinder)
            : base(accessTokenManager, pathFinder) { }
    }
}