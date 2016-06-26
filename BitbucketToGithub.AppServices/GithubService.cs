using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Core;
using BitBucketToGithub.Repository.Contracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace BitbucketToGithub.AppServices
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class GithubService : IGithubService
    {
        private readonly IGithubResponseRepository _githubResponseRepository;

        public GithubService(IGithubResponseRepository githubResponseRepository)
        {
            _githubResponseRepository = githubResponseRepository;
        }

        public void GetAccessTokenByCode(string code, string key, string secret)
        {
            var restClient = new RestClient("https://github.com/");

            var request = new RestRequest("login/oauth/access_token", Method.POST);

            request.AddParameter("client_id", key);
            request.AddParameter("client_secret", secret);
            request.AddParameter("code", code);

            var content = restClient.Execute(request).Content;
            var accessTokenResponse = JsonConvert.DeserializeObject<GithubAccessTokenResponse>(content,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            _githubResponseRepository.SaveChanges(accessTokenResponse);
        }
    }
}