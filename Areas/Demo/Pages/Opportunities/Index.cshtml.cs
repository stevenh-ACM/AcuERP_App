#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcuERP_App.Data;
using AcuERP_App.Models;

namespace AcuERP_App.Areas.Demo.Pages.Opportunities
{
    public class IndexModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public IndexModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<OP_Opportunity> OP_Opportunity { get;set; }

        public async Task OnGetAsync()
        {
            OP_Opportunity = await _context.OP_Opportunities.ToListAsync();
        }
    }
}
