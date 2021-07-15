using Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Escritor: Person
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public bool Publicidad { get; set; }
    }
}
