using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

using VemDeZap.Domain.Entities;
using VemDeZap.Infra.Repositories.Map;

namespace VemDeZap.Infra.Repositories.Base
{
    public partial class VemDeZapContext : DbContext
    {
        //Criar as tabelas
        public DbSet<User> User { get; set; }
        public DbSet<Campaign> Campaign { get; set; }
        public DbSet<Send> Send { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Contact> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=vemdezap;Uid=root;Pwd=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //ignorar classes
            modelBuilder.Ignore<Notification>();
            //modelBuilder.Ignore<Nome>();
            //modelBuilder.Ignore<Email>();

            //aplicar configurações
            modelBuilder.ApplyConfiguration(new MapUser());
            modelBuilder.ApplyConfiguration(new MapGroup());
            modelBuilder.ApplyConfiguration(new MapContact());
            modelBuilder.ApplyConfiguration(new MapCampaign());
            modelBuilder.ApplyConfiguration(new MapSend());


            base.OnModelCreating(modelBuilder);
        }
    }
}
