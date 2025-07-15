using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Estudio> Estudios { get; set; }

        public Especialidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Estudios = new List<Estudio>();
        }
    }

}
