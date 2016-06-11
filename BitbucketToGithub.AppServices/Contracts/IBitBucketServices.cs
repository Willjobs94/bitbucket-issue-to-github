using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitbucketToGithub.AppServices.DTOs;

namespace BitbucketToGithub.AppServices.Contracts
{
    public interface IBitBucketServices
    {
        BitBucketCredentialResponse GetAccessTokenByCode(string code);
    }
}
