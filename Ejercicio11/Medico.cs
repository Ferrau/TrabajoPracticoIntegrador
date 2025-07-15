using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    
    public class Medico
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal CostoBase { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public Agenda Agenda { get; set; }

        public Medico(int id, string nombre, string apellido, decimal costoBase)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            CostoBase = costoBase;
            Especialidades = new List<Especialidad>();
            Agenda = new Agenda();
        }

        public decimal CalcularCosto()
        {
            return CostoBase + (CostoBase * 0.15m * Especialidades.Count);
        }
    }


}
