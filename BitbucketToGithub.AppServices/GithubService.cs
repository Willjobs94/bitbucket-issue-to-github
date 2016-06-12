using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.AppServices.DTOs;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace BitbucketToGithub.AppServices
{
    public class GithubService : IGithubService
    {
        
        public void GetAccessTokenByCode(string code, string key, string secret)
        {
            var restClient = new RestClient("https://github.com/");
            
            var request = new RestRequest("login/oauth/access_token", Method.POST);

            request.AddParameter("client_id", key);
            request.AddParameter("client_secret", secret);
            request.AddParameter("code", code);

            var content = restClient.Execute(request).Content;
           var accessTokenResponse = JsonConvert.DeserializeObject<GithubAccessTokenResponse>(content, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

        }

   }
}
