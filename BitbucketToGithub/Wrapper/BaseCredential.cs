using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Wrapper
{
    public abstract class BaseCredential : IBaseCredential
    {
        protected BaseCredential(string credentialProviderName)
        {
            _credentialProviderName = credentialProviderName;
        }

        public string Key 
            => ConfigurationManager.AppSettings[_credentialProviderName + "Key"];

        public string Secret 
            => ConfigurationManager.AppSettings[_credentialProviderName + "Secret"];

        private readonly string _credentialProviderName;
    }
}