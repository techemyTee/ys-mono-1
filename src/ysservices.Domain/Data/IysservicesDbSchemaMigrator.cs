using System.Threading.Tasks;

namespace ysservices.Data;

public interface IysservicesDbSchemaMigrator
{
    Task MigrateAsync();
}
