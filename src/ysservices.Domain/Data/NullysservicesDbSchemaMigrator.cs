using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ysservices.Data;

/* This is used if database provider does't define
 * IysservicesDbSchemaMigrator implementation.
 */
public class NullysservicesDbSchemaMigrator : IysservicesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
