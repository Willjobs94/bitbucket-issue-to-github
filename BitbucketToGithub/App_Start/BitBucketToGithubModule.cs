using BitbucketToGithub.Wrapper;
using BitbucketToGithub.Wrapper.Contracts;
using Ninject.Modules;

namespace BitbucketToGithub.App_Start
{
    public class BitBucketToGithubModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfigurationWrapper>().To<ConfigurationWrapper>();
        }
    }
}