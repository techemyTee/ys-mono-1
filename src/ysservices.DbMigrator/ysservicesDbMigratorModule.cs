using ysservices.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ysservices.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ysservicesEntityFrameworkCoreModule),
    typeof(ysservicesApplicationContractsModule)
)]
public class ysservicesDbMigratorModule : AbpModule
{
}
