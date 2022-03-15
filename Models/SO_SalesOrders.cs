
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Sales Orders
/// </summary>
public class SO_SalesOrders
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool Approved { get; set; }
    public string ContactID { get; set; }
    public string CustomerID { get; set; }
    public string CustomerOrder { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public bool Hold { get; set; }
    public decimal OrderedQty { get; set; }
    public string OrderNbr { get; set; }
    public decimal OrderTotal { get; set; }
    public string OrderType { get; set; }
    public string ShipToAddress { get; set; }
    public string Status { get; set; }
    public decimal Totals { get; set; }
}
