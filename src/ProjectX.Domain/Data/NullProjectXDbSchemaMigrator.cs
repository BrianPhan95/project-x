using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProjectX.Data;

/* This is used if database provider does't define
 * IProjectXDbSchemaMigrator implementation.
 */
public class NullProjectXDbSchemaMigrator : IProjectXDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
