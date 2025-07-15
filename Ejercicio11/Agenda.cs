using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{

    public class Agenda
    {
        public List<Turno> Turnos { get; set; }

        public Agenda()
        {
            Turnos = new List<Turno>();
        }

        public bool ReservarTurno(Turno nuevoTurno)
        {
            foreach (var turno in Turnos)
            {
                if (turno.FechaHora == nuevoTurno.FechaHora)
                {
                    return false; // Turno ya reservado
                }
            }
            Turnos.Add(nuevoTurno);
            return true;
        }

        public List<Turno> ObtenerTurnos(DateTime fecha)
        {
            return Turnos.FindAll(t => t.FechaHora.Date == fecha.Date);
        }

        public bool CancelarTurno(Turno turno)
        {
            return Turnos.Remove(turno);
        }
    }

}
