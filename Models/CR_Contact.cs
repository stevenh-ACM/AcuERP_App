
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Contacts
/// </summary>
public class CR_Contact
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public bool? Active { get; set; } = false;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Address { get; set; } = String.Empty;
    
    [Required]
    [Display(Name = "Business Account")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string BusinessAccount { get; set; } = String.Empty;

    [Display(Name = "Company Name")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string CompanyName { get; set; } = String.Empty;

    [Display(Name = "Contact Class")]
    public string ContactClass { get; set; } = String.Empty;

    [Required]
    [Display(Name = "Contact ID")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public int? ContactID { get; set; }

    [Display(Name = "Display Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string DisplayName { get; set; } = String.Empty;

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = String.Empty;

    [Display(Name = "First Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string FirstName { get; set; } = String.Empty;

    [Display(Name = "Job Title")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string JobTitle { get; set; } = String.Empty;

    [Display(Name = "Last Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string LastName { get; set; } = String.Empty;

    [Display(Name = "Middle Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? MiddleName { get; set; } = String.Empty;

    [Display(Name = "Employee ID")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string Owner { get; set; } = String.Empty;

    [Display(Name = "Employee Name")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string OwnerEmployeeName { get; set; } = String.Empty;

    [Display(Name = "Parent Account")]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    public string ParentAccount { get; set; } = String.Empty;

    [Display(Name = "Phone Number")]
    [DataType(DataType.PhoneNumber)]
    public string Phone1 { get; set; } = String.Empty;

    [Display(Name = "Phone Type")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
    public string Phone1Type { get; set; } = String.Empty;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Title { get; set; } = String.Empty;

    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string Type { get; set; } = String.Empty;

}