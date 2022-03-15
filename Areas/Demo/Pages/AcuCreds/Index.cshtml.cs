
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.AcuCreds;

public class IndexModel : PageModel
{
    private readonly AcuERP_App.Data.AppDbContext _context;

    public IndexModel(AcuERP_App.Data.AppDbContext context)
    {
        _context = context;
    }

    public IList<AcuAuth> AcuAuth { get; set; }

    public async Task OnGetAsync()
    {
        AcuAuth = await _context.AcuAuths.ToListAsync();
    }
}
