
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AcuERP_App.Areas.Demo.Pages.Home;

public class AboutRevisionTwoModel : PageModel
{
    private readonly ILogger<AboutRevisionTwoModel> _logger;

    public AboutRevisionTwoModel(ILogger<AboutRevisionTwoModel> logger)
    {
        _logger = logger;
    }
    public void OnGet()
    {
    }
}
