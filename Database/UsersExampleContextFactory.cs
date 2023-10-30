using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class UsersExampleContextFactory : IDesignTimeDbContextFactory<UsersExampleContext>
    {
        public UsersExampleContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UsersExampleContext>();
            optionsBuilder.UseSqlServer("Server=GATEWYMIGUEL;Database=users_example;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True");

            return new UsersExampleContext(optionsBuilder.Options);
        }
    }
}
