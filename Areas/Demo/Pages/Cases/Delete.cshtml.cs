
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Cases;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CR_Cases = await _context.CR_Cases.FindAsync(id);

        if (CR_Cases != null)
        {
            _context.CR_Cases.Remove(CR_Cases);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
