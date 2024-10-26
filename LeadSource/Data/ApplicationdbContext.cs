using LeadSource.Models;
using Microsoft.EntityFrameworkCore;

namespace LeadSource.Data
{
    public class ApplicationdbContext : DbContext
    {
        public ApplicationdbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LeadEntity> Leads { get; set; }
    }
}
