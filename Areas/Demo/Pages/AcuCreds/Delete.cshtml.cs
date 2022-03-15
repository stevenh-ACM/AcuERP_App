#nullable disable
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.AcuCreds;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        AcuAuth = await _context.AcuAuths.FindAsync(id);

        if (AcuAuth != null)
        {
            _context.AcuAuths.Remove(AcuAuth);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
