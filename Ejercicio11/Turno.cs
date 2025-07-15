using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    

    public class Turno
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public Paciente Paciente { get; set; }

        public Turno(int id, DateTime fechaHora, Paciente paciente)
        {
            Id = id;
            FechaHora = fechaHora;
            Paciente = paciente;
        }
    }

}
