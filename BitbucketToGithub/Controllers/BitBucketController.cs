using System.Web.Mvc;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Utility.Contracts;

namespace BitbucketToGithub.Controllers
{
    public class BitBucketController : Controller
    {
        private readonly IBitbucketService _bitbucketService;
        private readonly IConfigurationWrapper _configurationWrapper;

        public BitBucketController(IConfigurationWrapper configurationWrapper, IBitbucketService bitbucketService)
        {
            _configurationWrapper = configurationWrapper;
            _bitbucketService = bitbucketService;
        }

        // GET: BitBucket
        public ActionResult SignIn()
        {
            return
                Redirect(
                    $"https://bitbucket.org/site/oauth2/authorize?client_id={_configurationWrapper.BitBucketKey}&response_type=code");
        }

        // URL callback of bitbucket Authentication
        public ActionResult GetCode(string code)
        {
            _bitbucketService.GetAccessTokenByCode(code, _configurationWrapper.BitBucketKey,
                _configurationWrapper.BitBucketSecret);
            return RedirectToAction("Index", "Home", new {bitbucketAuthenticated = true});
        }
    }
}