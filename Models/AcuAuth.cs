
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Add profile data for application users by adding properties to the ApiDemoUser class
/// </summary>
public class AcuAuth
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public bool IsChecked { get; set; } = false;

    [Required]
    [Display(Name = "Acumatica ERP Host Url (e.g. http://localhost/acumaticaerp")]
    [DataType(DataType.Url)]
    public string SiteUrl { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Acumatica User ID")]
    [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
    public string UserName { get; set; } = "admin";

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; } = string.Empty;

    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Tenant { get; set; } = string.Empty;

    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 0)]
    public string? Branch { get; set; } = string.Empty;

    [Display(Name = "Locale (eg.'en-US')")]
    [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
    public string Locale { get; set; } = "en-US";
}
