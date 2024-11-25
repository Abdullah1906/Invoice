using InvoiceManagementSystem.Areas.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InvoiceManagementSystem.DataModel;

namespace InvoiceManagementSystem.Data;

public class InvoiceManagementSystemContext : IdentityDbContext<IdentityUser>
{
    public InvoiceManagementSystemContext(DbContextOptions<InvoiceManagementSystemContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

public DbSet<InvoiceManagementSystem.DataModel.Customer> Customer { get; set; } = default!;

}
