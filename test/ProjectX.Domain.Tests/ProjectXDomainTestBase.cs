using Volo.Abp.Modularity;

namespace ProjectX;

/* Inherit from this class for your domain layer tests. */
public abstract class ProjectXDomainTestBase<TStartupModule> : ProjectXTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
