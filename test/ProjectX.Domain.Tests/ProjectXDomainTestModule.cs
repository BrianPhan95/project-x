using Volo.Abp.Modularity;

namespace ProjectX;

[DependsOn(
    typeof(ProjectXDomainModule),
    typeof(ProjectXTestBaseModule)
)]
public class ProjectXDomainTestModule : AbpModule
{

}
