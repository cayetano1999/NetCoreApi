using Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class BookEntity : Book
    {
        public int Id { get; set; }
        public Escritor Escritor {get; set;}

    }
}
