using Demo.Application;
using Demo.Application.Helper;
using Demo.Domain.Entities;
using Demo.Infrastructure.Sql.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.Infrastructure.Sql
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<string, string>(
                encryptedData => EncryptionHelper.EncryptedData(encryptedData),
                decryptedData => EncryptionHelper.DecryptedData(decryptedData));

            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            modelBuilder.Entity<Employee>().Property(e => e.FirstName)
                .HasConversion(converter);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
