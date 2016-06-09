namespace BitbucketToGithub.Wrapper.Contracts
{
    public interface IBaseCredential
    {
        /// <summary>
        /// Containts the public key
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Contains the secret key
        /// </summary>
        string Secret { get; }
    }
}
