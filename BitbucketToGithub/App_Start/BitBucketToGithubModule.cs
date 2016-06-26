using BitbucketToGithub.AppServices;
using BitbucketToGithub.AppServices.Contracts;
using BitbucketToGithub.Data;
using BitbucketToGithub.Data.Contracts;
using BitbucketToGithub.Utility;
using BitbucketToGithub.Utility.Contracts;
using BitBucketToGithub.Repository;
using BitBucketToGithub.Repository.Contracts;
using Ninject.Modules;

namespace BitbucketToGithub.App_Start
{
    public class BitBucketToGithubModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBitbucketService>().To<BitbucketService>();
            Bind<IGithubService>().To<GithubService>();

            Bind<IBitbucketResponseRepository>().To<BitbucketResponseRepository>();
            Bind<IGithubResponseRepository>().To<GithubResponseRepository>();

            Bind<IConfigurationWrapper>().To<ConfigurationWrapper>();
            Bind<IPathResolver>().To<PathResolver>();
            Bind<IAccessTokenManager>().To<AccessTokenManager>();
        }
    }
}