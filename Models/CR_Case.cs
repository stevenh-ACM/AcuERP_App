
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Cases
/// </summary>
public class CR_Case
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Business Account")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 8)]
    public string BusinessAccount { get; set; } = String.Empty;

    [Display(Name = "Business Name")]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string BusinessAccountName { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Case ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string CaseID { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Class ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string ClassID { get; set; } = String.Empty;

    [Display(Name = "Closing Date")]
    [DataType(DataType.DateTime)]
    public DateTime? ClosingDate { get; set; } = DateTime.Now;

    [Display(Name = "Contact Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string ContactDisplayName { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Contact ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public int ContactID { get; set; }

    [Display(Name = "Contract ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string? Contract { get; set; } = String.Empty;

    [Display(Name = "Date Reported")]
    [DataType(DataType.DateTime)]
    public DateTime? DateReported { get; set; } = DateTime.Now;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Description { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Employee ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Owner { get; set; } = String.Empty;

    [Display(Name = "Employee Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string OwnerEmployeeName { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Priority { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Reason { get; set; } = String.Empty;

    [Required]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Status { get; set; } = String.Empty;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Subject { get; set; } = String.Empty;

}