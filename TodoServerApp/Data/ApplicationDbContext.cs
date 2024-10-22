using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<TaskItem> TaskItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TaskItem>().HasData([
                new () {Id = 1, Title = "Task1", Description = "TaskDescription", CreatedDate = DateTime.Now},
                new () {Id = 2, Title = "Task2", Description = "TaskDescription", CreatedDate = DateTime.Now},
                new () {Id = 3, Title = "Task3", Description = "TaskDescription", CreatedDate = DateTime.Now},
                new () {Id = 4, Title = "Task4", Description = "4", CreatedDate = DateTime.Now},
            ]);
        }
    }
}