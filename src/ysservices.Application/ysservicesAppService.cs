using ysservices.Localization;
using Volo.Abp.Application.Services;

namespace ysservices;

/* Inherit your application services from this class.
 */
public abstract class ysservicesAppService : ApplicationService
{
    protected ysservicesAppService()
    {
        LocalizationResource = typeof(ysservicesResource);
    }
}
