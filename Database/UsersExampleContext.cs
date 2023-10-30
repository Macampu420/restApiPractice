using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class UsersExampleContext : DbContext
    {
        public UsersExampleContext(DbContextOptions<UsersExampleContext> options) : base(options) { }

        /* Si queremos personalizar el nombre de las tablas podemos 
         * sobreescribir este método y especificarlo manuealmente
         * protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Task>().ToTable("Task");
        } */

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}