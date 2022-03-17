
//using AcuERP_App.Data;
//using AcuERP_App.Models;

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;

//namespace AcuERP_App.Areas.Demo.Pages.AcuCreds;

//public class IndexModel : PageModel
//{
//    private readonly ILogger<IndexModel> _logger;
//    private readonly AppDbContext _context;

//    public IndexModel(AppDbContext context, ILogger<IndexModel> logger)
//    {
//        _context = context;
//        _logger = logger;
//    }

//    /// <summary>
//    /// </summary>
//    [BindProperty]
//    public AcuAuth acuAuth { get; set; }

//    public IList<AcuAuth> acuAuths { get; set; }

//    /// <summary>
//    /// </summary>
//    public string ReturnUrl { get; set; }

//    /// <summary>
//    /// </summary>
//    [TempData]
//    public string Message { get; set; }

//    public async Task OnGetAsync()
//    {
//        if (!ModelState.IsValid)
//        {
//            RedirectToPage("./Index");
//        }

//        acuAuths = await _context.AcuAuths.ToListAsync();
//    }
//    public async Task<IActionResult> OnPostAsync()
//    {
//        if (!ModelState.IsValid)
//        {
//            return Page();
//        }

//        _context.AcuAuths.Add(acuAuth);
//        await _context.SaveChangesAsync();
//        Message = "Selection has been saved";

//        return RedirectToPage("./Index");
//    }

//    private void Selected(int id) 
//    {

//    }
//}