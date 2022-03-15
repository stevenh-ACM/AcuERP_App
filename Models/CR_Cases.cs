
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Cases
/// </summary>
public class CR_Cases
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string BusinessAccount { get; set; }
    public string BusinessAccountName { get; set; }
    public string CaseID { get; set; }
    public string ClassID { get; set; }
    public DateTime ClosingDate { get; set; }
    public string ContactDisplayName { get; set; }
    public int ContactID { get; set; }
    public string Contract { get; set; }
    public DateTime DateReported { get; set; }
    public string Description { get; set; }
    public string Owner { get; set; }
    public string OwnerEmployeeName { get; set; }
    public string Priority { get; set; }
    public string Reason { get; set; }
    public string Status { get; set; }
    public string Subject { get; set; }
}