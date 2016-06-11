using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.AppServices.DTOs;
using RestSharp;


namespace BitbucketToGithub.AppServices
{
    public class BitBucketService : IBitBucketServices
    {
        public BitBucketCredentialResponse GetAccessTokenByCode(string code)
        {
            var client = new RestClient("http://bitbucket.org");

            var request = new RestRequest();
            return new BitBucketCredentialResponse();
        }
    }
}
