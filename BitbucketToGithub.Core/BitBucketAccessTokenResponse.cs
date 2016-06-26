// ReSharper disable InconsistentNaming for automatic Json.Net serialization
namespace BitbucketToGithub.Core
{
    public class BitbucketAccessTokenResponse : BaseAccessTokenResponse
    {
        /// <summary>
        ///     Represent a second access token that allow you to refresh the access token after is expired
        /// </summary>
        public string Refresh_Token { get; set; }

        /// <summary>
        ///     Indicates in miliseconds the time in which the access token is going to expires
        /// </summary>
        public string Expires_In { get; set; }

        /// <summary>
        ///     Represent which access privilege the access token has, separated by space. Ej. "repository account"
        /// </summary>
        public string Scopes { get; set; }
    }
}