using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.AppServices.DTOs
{
    public class BitBucketAccessTokenResponse : BaseAccessTokenResponse
    {
        public string Refresh_Token { get; set; }
        public string Expires_In { get; set; }
        public string Scopes { get; set; }
    }
}
