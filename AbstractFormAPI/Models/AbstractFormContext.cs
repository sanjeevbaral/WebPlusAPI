using Microsoft.EntityFrameworkCore;

namespace AbstractFormAPI.Models
{
    public class AbstractFormContext : DbContext
    {
        public AbstractFormContext(DbContextOptions<AbstractFormContext> options)
            : base(options)
        {
        }

        public DbSet<AbstractForm> AbstractForms { get; set; }
    }
}