using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasM
{
    internal class Paciente
    {
        public Paciente(string nombrePaciente, string clave, string telefono)
        {
            NombrePaciente = nombrePaciente;
            Clave = clave;
            Telefono = telefono;
        }

        public  string NombrePaciente{ get; set; }
        public string Clave { get; set; }
        public string Telefono{ get; set; }

    }
}
