using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Base
{
    public abstract class Person
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }
    }
}
