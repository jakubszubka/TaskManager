using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaskManager.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Use the same connection string you put in Program.cs
            optionsBuilder.UseSqlite("Data Source=tasks.db");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
