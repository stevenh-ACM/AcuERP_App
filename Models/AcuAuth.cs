
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
    //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
    //[Display(Name = "Acumatica ERP Host Url (e.g. http://localhost/acumaticaerp")]
    public string SiteUrl { get; set; } = string.Empty;

    [Required]
    //[Display(Name = "Acumatica User ID")]
    public string UserName { get; set; } = string.Empty;

    [Required]
    //[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    //[DataType(DataType.Password)]
    //[Display(Name = "Password")]
    public string Password { get; set; } = string.Empty;

    //[Display(Name = "Tenant (default is null)")]
    public string Tenant { get; set; } = string.Empty;

    //[Display(Name = "Branch (default is null)")]
    public string Branch { get; set; } = string.Empty;

    //[Display(Name = "Locale (default is null)")]
    public string Locale { get; set; } = string.Empty;
}
