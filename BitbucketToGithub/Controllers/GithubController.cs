using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Wrapper.Contracts;

namespace BitbucketToGithub.Controllers
{
    public class GithubController : Controller
    {

        public GithubController(IConfigurationWrapper configurationWrapper, IGithubService githubService)
        {
            _githubService = githubService;
            _configurationWrapper = configurationWrapper;
        }
        // GET: Github
        public ActionResult SignIn()
        {
            return Redirect($"https://github.com/login/oauth/authorize?client_id={_configurationWrapper.GithubKey}");
        }

        public ActionResult GetCode(string code)
        {
            _githubService.GetAccessTokenByCode(code, _configurationWrapper.GithubKey, _configurationWrapper.GithubSecret);
            return RedirectToAction("index", "Home");
        }
       
        private readonly IConfigurationWrapper _configurationWrapper;
        private readonly IGithubService _githubService;
    }
}