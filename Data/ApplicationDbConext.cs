using Data.Configuration;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ApplicationDbConext : DbContext
    {
        public ApplicationDbConext(DbContextOptions<ApplicationDbConext> options): base (options)
        {

        }

        public DbSet<BookEntity> Books { get; set; }
        public DbSet<Escritor> Escritores { get; set; }

        protected override void OnModelCreating (ModelBuilder builder)
        {
            BookEntityBuilder.Configure(builder);
            EscritorConfigBuilder.Configure(builder);

        }

        public object Where()
        {
            throw new NotImplementedException();
        }
    }
}
