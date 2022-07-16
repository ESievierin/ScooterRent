using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ScooterRent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRent.EF 
{
    internal class ScooterRentContext : DbContext
{
        public ScooterRentContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=(LocalDB)\MSSQLLocalDB;initial catalog=ScooterRentDB;integrated security=True");
          
        }
        public DbSet<Customer> Customers { get; set; }



        public DbSet<Rent> Rents { get; set; }

        public DbSet<Scooter> Scooters { get; set; }

        public DbSet<Tarif> Tarifs  { get; set; }

    }
}
