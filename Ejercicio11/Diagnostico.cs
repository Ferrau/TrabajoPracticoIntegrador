using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public string Descripcion { get; set; }

        public Diagnostico(int id, Medico medico, Paciente paciente, string descripcion)
        {
            Id = id;
            Medico = medico;
            Paciente = paciente;
            Descripcion = descripcion;
        }
    }

}
