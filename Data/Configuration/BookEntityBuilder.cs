using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
   public class BookEntityBuilder
    {
        public static void Configure (ModelBuilder builder)
        {
            builder.Entity<BookEntity>(db =>
           {
               db.HasKey(b => b.Id);
               db.HasOne(b => b.Escritor);

           });
        }
    }
}
