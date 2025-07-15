using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
   
    public class GestorHospital : IGestorHospital
    {
        private List<Especialidad> especialidades;
        private List<Medico> medicos;
        private List<Paciente> pacientes;
        private List<Derivacion> derivaciones;
        private List<Estudio> estudios;

        public GestorHospital()
        {
            especialidades = new List<Especialidad>();
            medicos = new List<Medico>();
            pacientes = new List<Paciente>();
            derivaciones = new List<Derivacion>();
            estudios = new List<Estudio>();
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            especialidades.Add(especialidad);
        }

        public void AgregarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void AgregarDerivacion(Derivacion derivacion)
        {
            derivaciones.Add(derivacion);
        }

        public void AgregarEstudio(Estudio estudio)
        {
            estudios.Add(estudio);
        }

        public void RegistrarResultadoEstudio(int idEstudio, string resultado)
        {
            var estudio = estudios.FirstOrDefault(e => e.Id == idEstudio);
            if (estudio != null)
            {
                estudio.RegistrarResultado(resultado);
            }
        }

        public void GenerarRecetaMedica(Diagnostico diagnostico)
        {
            // Implementación para generar receta médica
        }

        public List<HistorialClinico> ObtenerHistoriaClinicaPaciente(int idPaciente)
        {
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);
            return paciente?.HistoriaClinica.OrderByDescending(h => h.Fecha).ToList();
        }

        public List<HistorialClinico> ObtenerHistoriaClinicaPorEspecialidad(int idPaciente, int idEspecialidad)
        {
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);
            return paciente?.HistoriaClinica.Where(h => h.Especialidad.Id == idEspecialidad).OrderByDescending(h => h.Fecha).ToList();
        }

        public decimal ObtenerCostoTotalTratamiento(int idPaciente)
        {
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);
            return paciente?.HistoriaClinica.SelectMany(h => h.Estudios).Sum(e => e.Costo) ?? 0;
        }

        public decimal ObtenerGananciaTotalHospital()
        {
            return estudios.Where(e => e.Realizado).Sum(e => e.Costo);
        }

        public List<Especialidad> ListarEspecialidadesPorGanancia()
        {
            return especialidades.OrderByDescending(e => e.Estudios.Where(est => est.Realizado).Sum(est => est.Costo)).ToList();
        }

        public List<Especialidad> ListarEspecialidadesPorCantidadPacientes()
        {
            return especialidades.OrderByDescending(e => derivaciones.Count(d => d.Especialidad.Id == e.Id)).ToList();
        }
    }

}
