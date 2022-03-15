
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.SalesOrders;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<SO_SalesOrders> SO_SalesOrders { get; set; }

    public async Task OnGetAsync()
    {
        SO_SalesOrders = await _context.SO_SalesOrders.ToListAsync();
    }
}
