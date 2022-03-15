
using AcuERP_App.Data;
using AcuERP_App.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Areas.Demo.Pages.Contacts;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public IList<CR_Contacts> CR_Contacts { get; set; }

    public async Task OnGetAsync()
    {
        CR_Contacts = await _context.CR_Contacts.ToListAsync();
    }
}
