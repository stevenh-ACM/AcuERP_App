
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcuERP_App.Models;

/// <summary>
///     Local Store of recently used Contacts
/// </summary>
public class CR_Contacts
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public bool Active { get; set; }
    public string Address { get; set; }
    public string BusinessAccount { get; set; }
    public string CompanyName { get; set; }
    public string ContactClass { get; set; }
    public int ContactID { get; set; }
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string JobTitle { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Owner { get; set; }
    public string OwnerEmployeeName { get; set; }
    public string ParentAccount { get; set; }
    public string Phone1 { get; set; }
    public string Phone1Type { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
}