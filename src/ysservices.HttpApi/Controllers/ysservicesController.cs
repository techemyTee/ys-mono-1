using ysservices.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ysservices.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ysservicesController : AbpControllerBase
{
    protected ysservicesController()
    {
        LocalizationResource = typeof(ysservicesResource);
    }
}
