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
using RestSharp.Authenticators;


namespace BitbucketToGithub.AppServices
{
    public class BitBucketService : IBitBucketService
    {
        public BitBucketCredentialResponse GetAccessTokenByCode(string code, string bitbucketKey, string bitbucketSecret)
        {

            var client = new RestClient("https://bitbucket.org/")
            {
                Authenticator = new HttpBasicAuthenticator(bitbucketKey, bitbucketSecret)
            };

            var request = new RestRequest("site/oauth2/access_token/", Method.POST);

            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("code", code);

            var content = client.Execute(request).Content;
            var bitbucketCredentialResponse = JsonConvert.DeserializeObject<BitBucketCredentialResponse>(content, new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            return bitbucketCredentialResponse;
        }
    }
}
