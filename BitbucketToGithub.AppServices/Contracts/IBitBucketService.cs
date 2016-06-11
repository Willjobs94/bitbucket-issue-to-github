using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitbucketToGithub.AppServices.DTOs;

namespace BitbucketToGithub.AppServices.Contracts
{
    public interface IBitBucketService
    {
        /// <summary>
        /// Get accesss credential of bitbucket
        /// </summary>
        /// <param name="code"></param>
        /// <param name="bitbucketKey"></param>
        /// <param name="bitbucketSecret"></param>
        /// <returns></returns>
        BitBucketCredentialResponse GetAccessTokenByCode(string code, string bitbucketKey, string bitbucketSecret);
    }
}
