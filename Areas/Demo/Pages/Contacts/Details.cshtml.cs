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

namespace AcuERP_App.Areas.Demo.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public DetailsModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public CR_Contact CR_Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CR_Contact = await _context.CR_Contacts.FirstOrDefaultAsync(m => m.Id == id);

            if (CR_Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
