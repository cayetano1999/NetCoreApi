using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Configuration
{
    public class EscritorConfigBuilder
    {
        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<Escritor>(db =>
           {
               db.HasKey(e => e.Id);
           });
        }
    }
}
