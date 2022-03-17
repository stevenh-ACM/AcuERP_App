
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

using AcuERP_App.Data;
using AcuERP_App.Models;

namespace AcuERP_App.Areas.Demo.Pages.AcuCreds
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IList<AcuAuth> AcuAuth { get;set; }

        public async Task OnGetAsync()
        {
            AcuAuth = await _context.AcuAuths.ToListAsync();
        }
    }
}
