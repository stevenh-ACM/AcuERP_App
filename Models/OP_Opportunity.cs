
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Opportunities
/// </summary>
public class OP_Opportunity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Address { get; set; } = String.Empty;

    [DataType(DataType.Currency)]
    public decimal? Amount { get; set; } = 0M;

    [Required]
    [Display(Name = "Business Account")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string BusinessAccount { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Class ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string ClassID { get; set; } = String.Empty;

    [Display(Name = "Contact Name")]
    [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    public string ContactDisplayName { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Contract ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public int? ContactID { get; set; }

    [Display(Name = "Contract Information")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? ContactInformation { get; set; } = String.Empty;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Details { get; set; } = String.Empty;

    [DataType(DataType.DateTime)]
    public DateTime? Estimation { get; set; } = DateTime.Now;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Location { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Opportunity ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string OpportunityID { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Employee ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Owner { get; set; } = String.Empty;

    [Display(Name = "Employee Name")]
    public string OwnerEmployeeName { get; set; } = String.Empty;

    [Display(Name = "Parent Account")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string ParentAccount { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Reason { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Stage { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Status { get; set; } = String.Empty;

    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Subject { get; set; } = String.Empty;

    [DataType(DataType.Currency)]
    public decimal? Total { get; set; } = 0M;
}
