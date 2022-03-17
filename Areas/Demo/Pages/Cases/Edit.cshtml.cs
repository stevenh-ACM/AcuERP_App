#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcuERP_App.Data;
using AcuERP_App.Models;

namespace AcuERP_App.Areas.Demo.Pages.Cases
{
    public class EditModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public EditModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CR_Case CR_Case { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CR_Case = await _context.CR_Cases.FirstOrDefaultAsync(m => m.Id == id);

            if (CR_Case == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CR_Case).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CR_CaseExists(CR_Case.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CR_CaseExists(int id)
        {
            return _context.CR_Cases.Any(e => e.Id == id);
        }
    }
}
