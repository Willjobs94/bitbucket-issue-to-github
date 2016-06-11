using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Controllers
{
    public class BitBucketController : Controller
    {

        public BitBucketController(IConfigurationWrapper configurationWrapper)
        {
            _configurationWrapper = configurationWrapper;
        }

        // GET: BitBucket
        public ActionResult SignIn()
        {
            return Redirect($"https://bitbucket.org/site/oauth2/authorize?client_id={_configurationWrapper.BitBucketKey}&response_type=code");
        }

        // URL callback of bitbucket Authentication
        public ActionResult GetCode(string code)
        {
            accessToken = code;
            return RedirectToAction("Index", "Home");
        }
        private string accessToken = string.Empty;
        private const string BaseBitbucketApiUrl = "https://api.bitbucket.org/2.0/";
        private readonly IConfigurationWrapper _configurationWrapper;

    }
}