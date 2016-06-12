using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.AppServices.DTOs
{
    public abstract class BaseAccessTokenResponse
    {
        public string Access_Token { get; set; }
        public string Token_type { get; set; }
    }
}
