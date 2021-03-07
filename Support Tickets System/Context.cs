using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Support_Tickets_System.Entities;
using Support_Tickets_System.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;


namespace Support_Tickets_System
{
    public class Context:DbContext
    {
        public DbSet<ClientType> ClientsType { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Tickets> Tickets { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ClientTypeConfiguration(modelBuilder.Entity<ClientType>());
            new ClientConfiguration(modelBuilder.Entity<Client>());
            new TicketsConfiguration(modelBuilder.Entity<Tickets>());


        }
    }
}
