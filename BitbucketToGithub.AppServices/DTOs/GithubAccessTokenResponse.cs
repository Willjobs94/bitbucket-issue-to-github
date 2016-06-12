using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.AppServices.DTOs
{
    public class GithubAccessTokenResponse : BaseAccessTokenResponse
    {
        public string Scope { get; set; }
    }
}
