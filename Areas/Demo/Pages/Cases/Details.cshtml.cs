#nullable disable
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Cases;

public class DetailsModel : PageModel
{
    private readonly AcuERP_App.Data.AppDbContext _context;

    public DetailsModel(AcuERP_App.Data.AppDbContext context)
    {
        _context = context;
    }

    public CR_Cases CR_Cases { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CR_Cases = await _context.CR_Cases.FirstOrDefaultAsync(m => m.Id == id);

        if (CR_Cases == null)
        {
            return NotFound();
        }
        return Page();
    }
}
