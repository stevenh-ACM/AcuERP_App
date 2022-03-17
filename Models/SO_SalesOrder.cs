
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Sales Orders
/// </summary>
public class SO_SalesOrder
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public bool? Approved { get; set; } = false;

    [Display(Name = "Contract ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string? ContactID { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Customer ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string CustomerID { get; set; } = String.Empty;

    [Display(Name = "Customer Order")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? CustomerOrder { get; set; } = String.Empty;
    public DateTime? Date { get; set; } = DateTime.Now;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Description { get; set; } = String.Empty;

    public bool? Hold { get; set; } = false;

    [Display(Name = "Order Qty")]
    [DataType(DataType.Currency)]
    public decimal? OrderedQty { get; set; } = 0M;

    [Required]
    [Display(Name = "Order Nbr")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string OrderNbr { get; set; } = String.Empty;

    [Display(Name = "Order Total")]
    public decimal? OrderTotal { get; set; } = 0M;

    [Required]
    [Display(Name = "Order Type")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string OrderType { get; set; } = String.Empty;

    [Display(Name = "Ship To Address")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string ShipToAddress { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Status { get; set; } = String.Empty;

    [DataType(DataType.Currency)]
    public decimal? Totals { get; set; } = 0M;
}
