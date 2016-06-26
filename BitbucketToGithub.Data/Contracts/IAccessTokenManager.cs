using BitbucketToGithub.Core;

namespace BitbucketToGithub.Data.Contracts
{
    public interface IAccessTokenManager
    {
        /// <summary>
        ///     Get the bitbucket and github access token response in one object
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <returns></returns>
        AccessTokenMain GetAccessTokenMain(string jsonPath);

        /// <summary>
        ///     Save github ot bitbucket access token in the given path
        /// </summary>
        /// <param name="accessTokenMain"></param>
        /// <param name="jsonPath"></param>
        void SaveChanges(AccessTokenMain accessTokenMain, string jsonPath);
    }
}