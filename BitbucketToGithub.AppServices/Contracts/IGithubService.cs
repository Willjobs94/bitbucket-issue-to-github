using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.AppServices.Contracts
{
    public interface IGithubService
    {
        void GetAccessTokenByCode(string code, string key, string secret);
    }
}
