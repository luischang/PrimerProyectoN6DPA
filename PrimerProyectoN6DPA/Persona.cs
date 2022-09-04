using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyectoN6DPA
{
    public class Persona
    {
        public int dni { get; set; }
        public string nombreCompleto { get; set; }
        public int edad { get; set; }

        public Persona()
        {

        }

        public Persona(int dni, string nombreCompleto, int edad)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.edad = edad;
        }


    }
}
