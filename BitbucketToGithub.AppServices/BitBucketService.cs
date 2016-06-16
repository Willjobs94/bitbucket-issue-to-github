using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Core;
using BitBucketToGithub.Repository.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Authenticators;

namespace BitbucketToGithub.AppServices
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BitbucketService : IBitbucketService
    {
        private readonly IBitbucketResponseRepository _bitbucketResponseRepository;

        public BitbucketService(IBitbucketResponseRepository bitbucketResponseRepository)
        {
            _bitbucketResponseRepository = bitbucketResponseRepository;
        }

        public void GetAccessTokenByCode(string code, string key, string secret)
        {
            var client = new RestClient("https://bitbucket.org/")
            {
                Authenticator = new HttpBasicAuthenticator(key, secret)
            };

            var request = new RestRequest("site/oauth2/access_token/", Method.POST);

            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", code);

            var content = client.Execute(request).Content;
            var bitbucketCredentialResponse = JsonConvert.DeserializeObject<BitbucketAccessTokenResponse>(content,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            _bitbucketResponseRepository.SaveChanges(bitbucketCredentialResponse);
        }
    }
}