
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Opportunities;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<OP_Opportunities> OP_Opportunities { get; set; }

    public async Task OnGetAsync()
    {
        OP_Opportunities = await _context.OP_Opportunities.ToListAsync();
    }
}
