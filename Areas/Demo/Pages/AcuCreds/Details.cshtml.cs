#nullable disable
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.AcuCreds;

public class DetailsModel : PageModel
{
    private readonly AcuERP_App.Data.AppDbContext _context;

    public DetailsModel(AcuERP_App.Data.AppDbContext context)
    {
        _context = context;
    }

    public AcuAuth AcuAuth { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        AcuAuth = await _context.AcuAuths.FirstOrDefaultAsync(m => m.Id == id);

        if (AcuAuth == null)
        {
            return NotFound();
        }
        return Page();
    }
}
