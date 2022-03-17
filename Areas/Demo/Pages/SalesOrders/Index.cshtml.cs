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
    public class IndexModel : PageModel
    {
        private readonly AcuERP_App.Data.AppDbContext _context;

        public IndexModel(AcuERP_App.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<SO_SalesOrder> SO_SalesOrder { get;set; }

        public async Task OnGetAsync()
        {
            SO_SalesOrder = await _context.SO_SalesOrders.ToListAsync();
        }
    }
}
