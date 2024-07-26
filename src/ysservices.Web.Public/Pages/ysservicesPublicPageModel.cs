using ysservices.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ysservices.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class ysservicesPublicPageModel : AbpPageModel
{
    protected ysservicesPublicPageModel()
    {
        LocalizationResourceType = typeof(ysservicesResource);
    }
}
