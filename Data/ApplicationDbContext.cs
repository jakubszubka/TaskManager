using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManager.Models;  // Make sure namespace matches your project

namespace TaskManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TodoTask> Tasks => Set<TodoTask>();
    }
}