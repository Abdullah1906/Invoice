using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using InvoiceManagementSystem.Data;
using InvoiceManagementSystem.Areas.Identity.Model;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("InvoiceManagementSystemContextConnection") ?? throw new InvalidOperationException("Connection string 'InvoiceManagementSystemContextConnection' not found.");

builder.Services.AddDbContext<InvoiceManagementSystemContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddRoles<IdentityRole>().AddEntityFrameworkStores<InvoiceManagementSystemContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InvoiceManagementSystemContextConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
