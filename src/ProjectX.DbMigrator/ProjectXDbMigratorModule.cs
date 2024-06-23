using ProjectX.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ProjectX.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProjectXEntityFrameworkCoreModule),
    typeof(ProjectXApplicationContractsModule)
    )]
public class ProjectXDbMigratorModule : AbpModule
{
}
