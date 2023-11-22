using E.ApplicationCore.Domain;
using E.Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Fete> Fete { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Invitation> Invitations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
            //           Initial Catalog=DS7-S8;
            //           Integrated Security=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InvitationConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<String>().HaveMaxLength(150);
        }
    }
}
