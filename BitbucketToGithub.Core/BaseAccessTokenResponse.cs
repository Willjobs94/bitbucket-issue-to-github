// ReSharper disable InconsistentNaming for automatic Json.Net serialization
namespace BitbucketToGithub.Core
{
    public abstract class BaseAccessTokenResponse
    {
        /// <summary>
        ///     Represente the access token
        /// </summary>
        public string Access_Token { get; set; }

        /// <summary>
        ///     Indicate the type of access token
        /// </summary>
        public string Token_type { get; set; }
    }
}