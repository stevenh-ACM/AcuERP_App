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

namespace AcuERP_App.Areas.Demo.Pages.SalesOrders
{
    public class DetailsModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public DetailsModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public SO_SalesOrder SO_SalesOrder { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SO_SalesOrder = await _context.SO_SalesOrders.FirstOrDefaultAsync(m => m.Id == id);

            if (SO_SalesOrder == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
