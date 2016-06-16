using System.IO;
using BitbucketToGithub.Core;
using BitbucketToGithub.Data.Contracts;
using Newtonsoft.Json;

namespace BitbucketToGithub.Data
{
    public class AccessTokenManager : IAccessTokenManager
    {
        public AccessTokenMain GetAccessTokenMain(string jsonPath)
        {
            using (var file = File.OpenText(jsonPath))
            {
                return JsonConvert.DeserializeObject<AccessTokenMain>(file.ReadToEnd());
            }
        }

        public void SaveChanges(AccessTokenMain accesstokenMain, string jsonPath)
        {
            var output = JsonConvert.SerializeObject(accesstokenMain, Formatting.Indented);
            File.WriteAllText(jsonPath, output);
        }
    }
}