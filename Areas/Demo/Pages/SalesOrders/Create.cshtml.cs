#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AcuERP_App.Data;
using AcuERP_App.Models;

namespace AcuERP_App.Areas.Demo.Pages.SalesOrders
{
    public class CreateModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public CreateModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SO_SalesOrder SO_SalesOrder { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SO_SalesOrders.Add(SO_SalesOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
