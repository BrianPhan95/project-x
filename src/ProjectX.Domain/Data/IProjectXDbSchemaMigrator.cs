using System.Threading.Tasks;

namespace ProjectX.Data;

public interface IProjectXDbSchemaMigrator
{
    Task MigrateAsync();
}
