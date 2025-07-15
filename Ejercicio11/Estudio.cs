using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public class Estudio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public int CupoDiario { get; set; }
        public string Resultado { get; set; }
        public bool Realizado { get; set; }
        public Medico MedicoSolicitante { get; set; }

        public Estudio(int id, string nombre, decimal costo, int cupoDiario)
        {
            Id = id;
            Nombre = nombre;
            Costo = costo;
            CupoDiario = cupoDiario;
            Realizado = false;
        }

        public void RegistrarResultado(string resultado)
        {
            Resultado = resultado;
            Realizado = true;
        }
    }

}
