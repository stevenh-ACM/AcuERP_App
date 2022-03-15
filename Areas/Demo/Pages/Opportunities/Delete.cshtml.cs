
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Opportunities;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public OP_Opportunities OP_Opportunities { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        OP_Opportunities = await _context.OP_Opportunities.FirstOrDefaultAsync(m => m.Id == id);

        if (OP_Opportunities == null)
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

        OP_Opportunities = await _context.OP_Opportunities.FindAsync(id);

        if (OP_Opportunities != null)
        {
            _context.OP_Opportunities.Remove(OP_Opportunities);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
