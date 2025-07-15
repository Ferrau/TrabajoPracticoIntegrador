using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    
    public class HistorialClinico
    {
        public DateTime Fecha { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Estudio> Estudios { get; set; }
        public Diagnostico Diagnostico { get; set; }

        public HistorialClinico(DateTime fecha, Especialidad especialidad, List<Estudio> estudios, Diagnostico diagnostico)
        {
            Fecha = fecha;
            Especialidad = especialidad;
            Estudios = estudios;
            Diagnostico = diagnostico;
        }
    }

}
