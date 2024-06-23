using Volo.Abp.Modularity;

namespace ProjectX;

public abstract class ProjectXApplicationTestBase<TStartupModule> : ProjectXTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
