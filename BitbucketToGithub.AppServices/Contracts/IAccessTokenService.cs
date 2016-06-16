namespace BitbucketToGithub.AppServices.Contracts
{
    public interface IAccessTokenService
    {
        /// <summary>
        ///     Get accesss token by code of bitbucket
        /// </summary>
        /// <param name="code"></param>
        /// <param name="key"></param>
        /// <param name="secret"></param>
        /// <returns></returns>
        void GetAccessTokenByCode(string code, string key, string secret);
    }
}