
//using AcuERP_App.Data;
//using AcuERP_App.Models;
//using AcuERP_App.Auxillary;

//using Acumatica.Auth.Api;
//using Acumatica.Default_20_200_001.Api;
//using Acumatica.Default_20_200_001.Model;

//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.EntityFrameworkCore;

//namespace AcuERP_App.Areas.Demo.Pages.SalesOrders;

//public class DetailsModel : PageModel
//{
//    private readonly ILogger<DetailsModel> _logger;
//    private readonly AppDbContext _context;

//    public DetailsModel(AppDbContext context, ILogger<DetailsModel> logger)
//    {
//        _context = context;
//        _logger = logger;
//    }

//    public SO_SalesOrders SO_SalesOrders { get; set; }

//    public AcuAuth acuAuth { get; set; }

//    public List<AcuAuth> acuAuths { get; set; }

//    public SalesOrder salesOrder { get; set; }

//      [BindProperty]
//      public SO_SalesOrders SO_SalesOrders { get; set; }

//    public async Task<IActionResult> OnGetAsync(int? id)
//    {
//        if (id == null)
//        {
//            return NotFound();
//        }
//        List<SalesOrder> salesOrders_ = new();
//        //acuAuths[0] = await _context.AcuAuths.FirstOrDefaultAsync(m => m.Id == id);
//        acuAuths = await _context.AcuAuths.ToListAsync();

//        var authApi = new AuthApi(acuAuths[0].SiteUrl,
//                                    requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);

//        try
//        {
//            var configuration = authApi.LogIn(acuAuths[0].UserName, acuAuths[0].Password, "", "", "");

//            Console.WriteLine("Reading SalesOrders...");
//            //var accountApi = new AccountApi(configuration);
//            //var accounts = accountApi.GetList(top: 5);

//            //foreach (var account in accounts)
//            //{
//            //    Console.WriteLine("Account Nbr: " + account.AccountCD.Value + ";");
//            //}
//            var salesOrderApi = new SalesOrderApi(configuration);
//            var salesOrders = salesOrderApi.GetList(top: 5);
//            salesOrders_ = salesOrders;
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine(e.Message);
//        }
//        finally
//        {
//            //we use logout in finally block because we need to always logut, even if the request failed for some reason
//            if (authApi.TryLogout())
//            {
//                Console.WriteLine("Logged out successfully.");
//            }
//            else
//            {
//                Console.WriteLine("An error occured during logout.");
//            }
//        }

//        foreach (var salesOrder in salesOrders_)
//        {
//            Console.WriteLine("SalesOrder Nbr: " + salesOrder.OrderNbr.Value + ";");
//            var so_SalesOrder = SalesOrderToSO_SalesOrder(salesOrder);
//            _context.SO_SalesOrders.Add(so_SalesOrder);
//        }
//        await _context.SaveChangesAsync();

//        //SO_SalesOrders = await _context.SO_SalesOrders.FirstOrDefaultAsync(m => m.Id == id);
//        SO_SalesOrders = await _context.SO_SalesOrders.ToListAsync();

//        if (SO_SalesOrders == null)
//        {
//            return NotFound();
//        }
//        return Page();
//    }

//    //			var authApi = new AuthApi(siteURL,
//    //				requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);

//    //			try
//    //			{
//    //				var configuration = authApi.LogIn(username, password, tenant, branch, locale);

//    //				Console.WriteLine("Reading Accounts...");
//    //				var accountApi = new AccountApi(configuration);
//    //				var accounts = accountApi.GetList(top: 5);
//    //				foreach (var account in accounts)
//    //				{
//    //					Console.WriteLine("Account Nbr: " + account.AccountCD.Value + ";");
//    //				}

//    //				Console.WriteLine("Reading Sales Order by Keys...");
//    //				var salesOrderApi = new SalesOrderApi(configuration);
//    //				var order = salesOrderApi.GetByKeys(new List<string>() { "SO", "SO005207" });
//    //				Console.WriteLine("Order Total: " + order.OrderTotal.Value);


//    //				var shipmentApi = new ShipmentApi(configuration);
//    //				var shipment = shipmentApi.GetByKeys(new List<string>() { "002805" });
//    //				Console.WriteLine("ConfirmShipment");
//    //				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new ConfirmShipment(shipment)));

//    //				Console.WriteLine("CorrectShipment");
//    //				shipmentApi.WaitActionCompletion(shipmentApi.InvokeAction(new CorrectShipment(shipment)));
//    //			}
//    //			catch (Exception e)
//    //			{
//    //				Console.WriteLine(e.Message);
//    //			}
//    //			finally
//    //			{
//    //				//we use logout in finally block because we need to always logut, even if the request failed for some reason
//    //				if (authApi.TryLogout())
//    //				{
//    //					Console.WriteLine("Logged out successfully.");
//    //				}
//    //				else
//    //				{
//    //					Console.WriteLine("An error occured during loguot.");
//    //				}
//    //			}
//    //		}

//    protected SO_SalesOrders SalesOrderToSO_SalesOrder(SalesOrder s)
//    {
//        if (s != null)
//        {
//            SO_SalesOrders so = new();
//            so.Approved = (bool)s.Approved;
//            so.ContactID = s.ContactID;
//            so.CustomerID = s.CustomerID;
//            so.CustomerOrder = s.CustomerOrder;
//            so.Date = (DateTime)s.Date;
//            so.Description = s.Description;
//            so.Hold = (bool)s.Hold;
//            so.OrderedQty = (decimal)s.OrderedQty.Value;
//            so.OrderNbr = s.OrderNbr;
//            so.OrderTotal = (decimal)s.OrderTotal.Value;
//            so.OrderType = s.OrderType;
//            so.ShipToAddress = "";
//            so.Status = s.Status;
//            if (s.Totals == null)
//            {
//                so.Totals = 0M;
//            }
//            else 
//            { 
//                so.Totals = (decimal)s.Totals.LineTotalAmount.Value; 
//            }   

//            return so;
//        }
//        return null;
//    }
//}