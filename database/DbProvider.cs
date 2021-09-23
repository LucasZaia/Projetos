using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projetos.Data;
using Projetos.Models;

namespace Projetos.database
{
    public class DbProvider : DbContext
    {
        public DbProvider(DbContextOptions<DbProvider> options) : base(options){}

        public DbSet<User> Users {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
        }
    }
}