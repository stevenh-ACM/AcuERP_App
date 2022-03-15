
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Contacts;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public CR_Contacts CR_Contacts { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        CR_Contacts = await _context.CR_Contacts.FirstOrDefaultAsync(m => m.Id == id);

        if (CR_Contacts == null)
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

        CR_Contacts = await _context.CR_Contacts.FindAsync(id);

        if (CR_Contacts != null)
        {
            _context.CR_Contacts.Remove(CR_Contacts);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
