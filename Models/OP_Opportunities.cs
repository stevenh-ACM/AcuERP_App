
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Opportunities
/// </summary>
public class OP_Opportunities
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Address { get; set; }
    public decimal Amount { get; set; }
    public string BusinessAccount { get; set; }
    public string ClassID { get; set; }
    public string ContactDisplayName { get; set; }
    public int ContactID { get; set; }
    public string ContactInformation { get; set; }
    public string Details { get; set; }
    public DateTime Estimation { get; set; }
    public string Location { get; set; }
    public string OpportunityID { get; set; }
    public string Owner { get; set; }
    public string OwnerEmployeeName { get; set; }
    public string ParentAccount { get; set; }
    public string Reason { get; set; }
    public string Stage { get; set; }
    public string Status { get; set; }
    public string Subject { get; set; }
    public decimal Total { get; set; }
}
