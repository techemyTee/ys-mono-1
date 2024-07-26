using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ysservices;

[Dependency(ReplaceServices = true)]
public class ysservicesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ysservices";
}
