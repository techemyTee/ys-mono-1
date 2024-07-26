using Volo.Abp.Modularity;

namespace ysservices;

public abstract class ysservicesApplicationTestBase<TStartupModule> : ysservicesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
