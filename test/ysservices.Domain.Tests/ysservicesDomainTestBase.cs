using Volo.Abp.Modularity;

namespace ysservices;

/* Inherit from this class for your domain layer tests. */
public abstract class ysservicesDomainTestBase<TStartupModule> : ysservicesTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
