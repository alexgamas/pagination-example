using System;
using Microsoft.EntityFrameworkCore;
using sorteio.models;

namespace sorteio.repository
{
    public class Context : DbContext
    {
        public DbSet<Area> Areas { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Console.WriteLine("Modelo Criado");
        }

    }
}

