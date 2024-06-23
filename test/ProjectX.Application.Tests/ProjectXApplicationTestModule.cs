using Volo.Abp.Modularity;

namespace ProjectX;

[DependsOn(
    typeof(ProjectXApplicationModule),
    typeof(ProjectXDomainTestModule)
)]
public class ProjectXApplicationTestModule : AbpModule
{

}
