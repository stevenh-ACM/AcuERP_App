
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Cases;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<CR_Cases> CR_Cases { get; set; }

    public async Task OnGetAsync()
    {
        CR_Cases = await _context.CR_Cases.ToListAsync();
    }
}
