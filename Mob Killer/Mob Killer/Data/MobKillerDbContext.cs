﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mob_Killer.Entities;
using Mob_Killer.Repository;

namespace Mob_Killer.Data
{
    public class MobKillerDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Monster> Monsters { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Dialogue> Dialogue { get; set; }

        public DbSet<Enigma> Enigmas { get; set; }

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

            modelBuilder.Entity<Enigma>().ToTable("Enigma");


        }
    }
}