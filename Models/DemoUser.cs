
using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Add profile data for application users by adding properties to the ApiDemoUser class
/// </summary>
public class DemoUser : IdentityUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [PersonalData]
    public string Name { get; set; }

    [PersonalData]
    [DataType(DataType.Date)]
    public DateTime? DOB { get; set; }

}

