
using AcuERP_App.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcuERP_App.Data;

public class AppDbContext : IdentityDbContext<DemoUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<AcuAuth> AcuAuths { get; set; }

    public DbSet<CR_Case> CR_Cases { get; set; }

    public DbSet<CR_Contact> CR_Contacts { get; set; }

    public DbSet<OP_Opportunity> OP_Opportunities { get; set; }

    public DbSet<SO_SalesOrder> SO_SalesOrders { get; set; }
}
