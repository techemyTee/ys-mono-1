using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ysservices.Web.Public.Pages;

public class IndexModel : ysservicesPublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
