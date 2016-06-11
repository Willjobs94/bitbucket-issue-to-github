using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.AppServices.DTOs
{
    public class BitBucketCredentialResponse
    {
        public string Access_Token { get; set; }
        public string Refresh_Token { get; set; }
        public string Token_type { get; set; }
        public string Expires_In { get; set; }
        public string Scopes { get; set; }
    }
}
