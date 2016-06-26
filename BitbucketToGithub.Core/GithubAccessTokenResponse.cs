namespace BitbucketToGithub.Core
{
    public class GithubAccessTokenResponse : BaseAccessTokenResponse
    {
        /// <summary>
        ///     Represent which access privilege the access token has, separated by space. Ej. "repository account"
        /// </summary>
        public string Scope { get; set; }
    }
}