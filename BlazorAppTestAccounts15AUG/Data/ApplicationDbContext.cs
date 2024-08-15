using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorAppTestAccounts15AUG.Models;

namespace BlazorAppTestAccounts15AUG.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<BlazorAppTestAccounts15AUG.Models.WebSite> WebSite { get; set; } = default!;
        public DbSet<BlazorAppTestAccounts15AUG.Models.WebPage> WebPage { get; set; } = default!;
    }
}
