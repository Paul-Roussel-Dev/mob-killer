using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mob_Killer.Entities;

namespace Mob_Killer.Data
{
    public class MobKillerDbContext : DbContext
    {
        public DbSet<Joueur> Joueurs { get; set; }

        public DbSet<Monstre> Monstres { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=samurai;Integrated Security=True;");
            optionsBuilder.UseSqlite("Data Source=mobKiller.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");

            modelBuilder.Entity<Monstre>().ToTable("Monstre");

            modelBuilder.Entity<Joueur>()
                .HasKey(s => new { s.ItemId });

            modelBuilder.Entity<Item>(s =>
            {
                s.HasKey(p => p.IdItem);
                s.Property(p => p.NameItem).IsRequired();
                s.Property(p => p.BaseAttack).IsRequired();
                s.Property(p => p.BonusEvasion).IsRequired();
            });

            //modelBuilder.Entity<Quote>(q =>
            //{
            //    q.Property(p => p.Text).IsRequired();
            //});
        }
    }
}
