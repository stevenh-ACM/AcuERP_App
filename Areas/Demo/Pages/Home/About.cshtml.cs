
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcuERP_App.Areas.Demo.Pages.Home;

public class AboutModel : PageModel
{
    private readonly ILogger<AboutModel> _logger;

    public AboutModel(ILogger<AboutModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
    }
}
