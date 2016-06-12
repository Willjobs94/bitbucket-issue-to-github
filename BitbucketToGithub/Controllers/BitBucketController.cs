using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Controllers
{
    public class BitBucketController : Controller
    {

        public BitBucketController(IConfigurationWrapper configurationWrapper, IBitBucketService bitBucketService)
        {
            _configurationWrapper = configurationWrapper;
            _bitBucketService = bitBucketService;
        }

        // GET: BitBucket
        public ActionResult SignIn()
        {
            return Redirect($"https://bitbucket.org/site/oauth2/authorize?client_id={_configurationWrapper.BitBucketKey}&response_type=code");
        }

        // URL callback of bitbucket Authentication
        public ActionResult GetCode(string code)
        {
           var bitbucketAccess = _bitBucketService.GetAccessTokenByCode(code, _configurationWrapper.BitBucketKey,
                _configurationWrapper.BitBucketSecret);
            return RedirectToAction("Index", "Home", new {bitbucketAuthenticated = true});
        }
        private readonly IConfigurationWrapper _configurationWrapper;
        private readonly IBitBucketService _bitBucketService;
    }
}