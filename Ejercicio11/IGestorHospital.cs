using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public interface IGestorHospital
    {
        void AgregarEspecialidad(Especialidad especialidad);
        void AgregarMedico(Medico medico);
        void AgregarPaciente(Paciente paciente);
        void AgregarDerivacion(Derivacion derivacion);
        void AgregarEstudio(Estudio estudio);
        void RegistrarResultadoEstudio(int idEstudio, string resultado);
        void GenerarRecetaMedica(Diagnostico diagnostico);
        List<HistorialClinico> ObtenerHistoriaClinicaPaciente(int idPaciente);
        List<HistorialClinico> ObtenerHistoriaClinicaPorEspecialidad(int idPaciente, int idEspecialidad);
        decimal ObtenerCostoTotalTratamiento(int idPaciente);
        decimal ObtenerGananciaTotalHospital();
        List<Especialidad> ListarEspecialidadesPorGanancia();
        List<Especialidad> ListarEspecialidadesPorCantidadPacientes();
    }

}
