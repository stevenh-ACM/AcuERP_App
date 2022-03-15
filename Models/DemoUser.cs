
using Microsoft.AspNetCore.Identity;

namespace AcuERP_App.Models;

/// <summary>
///     Add profile data for application users by adding properties to the ApiDemoUser class
/// </summary>
public class DemoUser : IdentityUser
{
    [PersonalData]
    public string Name { get; set; }
    [PersonalData]
    public DateTime DOB { get; set; }

}

