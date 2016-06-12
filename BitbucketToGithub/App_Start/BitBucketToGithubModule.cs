using BitbucketToGithub.AppServices;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Wrapper;
using BitbucketToGithub.Wrapper.Contracts;
using Ninject.Modules;
using RestSharp;

namespace BitbucketToGithub.App_Start
{
    public class BitBucketToGithubModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationWrapper>().To<ConfigurationWrapper>();

            Bind<IBitBucketService>().To<BitBucketService>();
            Bind<IGithubService>().To<GithubService>();
        }
    }
}