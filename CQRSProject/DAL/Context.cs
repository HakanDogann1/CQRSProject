using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NOMRM5V\\SQLEXPRESS;initial catalog=CQRSdb;integrated security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
