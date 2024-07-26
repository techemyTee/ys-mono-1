using Volo.Abp.Modularity;

namespace ysservices;

[DependsOn(
    typeof(ysservicesDomainModule),
    typeof(ysservicesTestBaseModule)
)]
public class ysservicesDomainTestModule : AbpModule
{

}
