using Microsoft.EntityFrameworkCore;

namespace AGIT_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<RevenueByItemGroup> RevenueByItemGroups { get; set; }
        public DbSet<RevenueByCountry> RevenueByCountries { get; set; }
    }

    public class RevenueByItemGroup
    {
        public int Id { get; set; }
        public string ItemGroup { get; set; }
        public long Revenue { get; set; }
    }

    public class RevenueByCountry
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public long Revenue { get; set; }
    }
}
