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
        public DbSet<Player> Players { get; set; }

        public DbSet<Monster> Monsters { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Dialogue> Dialogue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=samurai;Integrated Security=True;");
            optionsBuilder.UseSqlite("Data Source=mobKiller.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().ToTable("Player");

            modelBuilder.Entity<Item>().ToTable("Item");

            modelBuilder.Entity<Monster>().ToTable("Monster");

            modelBuilder.Entity<Dialogue>().ToTable("Dialogue");

            modelBuilder.Entity<Player>()
                .HasKey(s => new { s.Id });

            modelBuilder.Entity<Item>(s =>
            {
                s.HasKey(p => p.Id);
                s.Property(p => p.Name).IsRequired();
                s.Property(p => p.BaseAttack).IsRequired();
                s.Property(p => p.BonusEvasion).IsRequired();
            });

            modelBuilder.Entity<Monster>()
                .HasKey(s => new { s.Id });

            modelBuilder.Entity<Dialogue>(s =>
            {
                s.HasKey(p => p.Id);
                s.Property(p => p.Type).IsRequired();
                s.Property(p => p.Text).IsRequired();
            });

            //modelBuilder.Entity<Quote>(q =>
            //{
            //    q.Property(p => p.Text).IsRequired();
            //});
        }
    }
}