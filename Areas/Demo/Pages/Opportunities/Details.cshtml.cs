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
    public class DetailsModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public DetailsModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public OP_Opportunity OP_Opportunity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OP_Opportunity = await _context.OP_Opportunities.FirstOrDefaultAsync(m => m.Id == id);

            if (OP_Opportunity == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
