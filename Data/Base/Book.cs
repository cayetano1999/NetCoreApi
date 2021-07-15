using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Base
{
    public abstract class Book
    {
        public string Title { get; set; }
        public int PagesCount { get; set; }

        public DateTime FechaCreacion { get; set; }


    }
}
