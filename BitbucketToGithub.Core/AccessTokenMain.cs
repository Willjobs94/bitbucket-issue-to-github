namespace BitbucketToGithub.Core
{
    /// <summary>
    ///     Represent a unique object containing access tokens response as property
    /// </summary>
    public class AccessTokenMain
    {
        /// <summary>
        ///     Represent the Bitbucket access token response
        /// </summary>
        public BitbucketAccessTokenResponse Bitbucket { get; set; }

        /// <summary>
        ///     Represent the Github access token Github
        /// </summary>
        public GithubAccessTokenResponse Github { get; set; }
    }
}