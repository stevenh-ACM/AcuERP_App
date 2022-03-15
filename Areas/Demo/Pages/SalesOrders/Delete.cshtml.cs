
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.SalesOrders;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public SO_SalesOrders SO_SalesOrders { get; set; }

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        SO_SalesOrders = await _context.SO_SalesOrders.FirstOrDefaultAsync(m => m.Id == id);

        if (SO_SalesOrders == null)
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

        SO_SalesOrders = await _context.SO_SalesOrders.FindAsync(id);

        if (SO_SalesOrders != null)
        {
            _context.SO_SalesOrders.Remove(SO_SalesOrders);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
