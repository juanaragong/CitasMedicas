using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasM
{
    internal class CitaMedica
    {
        public CitaMedica(DateTime fecha, TimeSpan hora, Paciente paciente, string motivo)
        {
            Fecha = fecha;
            Hora = hora;
            Paciente = paciente;
            Motivo = motivo;
        }

        public DateTime Fecha { get; set; }
        public  TimeSpan Hora { get; set; }
        public  Paciente Paciente { get; set; }
        public  string Motivo { get; set; }
    }
}
