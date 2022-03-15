
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Home;

public class SetupModel : PageModel
{
    private readonly ILogger<SetupModel> _logger;
    private readonly AppDbContext _context;

    public SetupModel(AppDbContext context, ILogger<SetupModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    /// <summary>
    /// </summary>
    [BindProperty]
    public AcuAuth acuAuth { get; set; }

    public IList<AcuAuth> acuAuths { get; set; }

    /// <summary>
    /// </summary>
    public string ReturnUrl { get; set; }

    /// <summary>
    /// </summary>
    [TempData]
    public string ErrorMessage { get; set; }

    public async Task OnGetAsync()
    {
        if (!ModelState.IsValid)
        {
            RedirectToPage("./Setup");
        }

        acuAuths = await _context.AcuAuths.ToListAsync();
    }
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.AcuAuths.Add(acuAuth);
        await _context.SaveChangesAsync();


        return RedirectToPage("./Main");
    }
}


