using Volo.Abp.Modularity;

namespace ysservices;

[DependsOn(
    typeof(ysservicesApplicationModule),
    typeof(ysservicesDomainTestModule)
)]
public class ysservicesApplicationTestModule : AbpModule
{

}
