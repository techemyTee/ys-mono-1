using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ysservices.Web.Public;

[Dependency(ReplaceServices = true)]
public class ysservicesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ysservices";
}
