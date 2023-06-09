﻿using AG_TicketPass.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace AG_TicketPass.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }



        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(t => t.Id).IsUnique();
        }

    }
}
