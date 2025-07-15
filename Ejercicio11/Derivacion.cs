using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Derivacion
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public Especialidad Especialidad { get; set; }
        public DateTime FechaDerivacion { get; set; }

        public Derivacion(int id, Paciente paciente, Medico medico, Especialidad especialidad, DateTime fechaDerivacion)
        {
            Id = id;
            Paciente = paciente;
            Medico = medico;
            Especialidad = especialidad;
            FechaDerivacion = fechaDerivacion;
        }
    }

}
