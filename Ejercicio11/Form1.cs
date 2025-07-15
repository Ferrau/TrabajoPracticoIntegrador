using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            var formEspecialidad = new EspecialidadForm(gestorHospital);
            //formEspecialidad.ShowDialog();
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            //var formMedico = new MedicoForm(gestorHospital);
            //formMedico.ShowDialog();
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            //var formPaciente = new PacienteForm(gestorHospital);
            //formPaciente.ShowDialog();
        }

        private void btnAgregarDerivacion_Click(object sender, EventArgs e)
        {
            //var formDerivacion = new DerivacionForm(gestorHospital);
            //formDerivacion.ShowDialog();
        }

        private void btnAgregarEstudio_Click(object sender, EventArgs e)
        {
            //var formEstudio = new EstudioForm(gestorHospital);
            //formEstudio.ShowDialog();
        }

        private void btnRegistrarResultado_Click(object sender, EventArgs e)
        {
            //var formResultado = new ResultadoForm(gestorHospital);
            //formResultado.ShowDialog();
        }

        private void btnGenerarReceta_Click(object sender, EventArgs e)
        {
            //var formReceta = new RecetaForm(gestorHospital);
            //formReceta.ShowDialog();
        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            //var formHistoriaClinica = new HistoriaClinicaForm(gestorHospital);
            //formHistoriaClinica.ShowDialog();
        }

        private void btnCostoTotalTratamiento_Click(object sender, EventArgs e)
        {
            //var formCostoTratamiento = new CostoTratamientoForm(gestorHospital);
            //formCostoTratamiento.ShowDialog();
        }

        private void btnGananciaTotal_Click(object sender, EventArgs e)
        {
            //var gananciaTotal = gestorHospital.ObtenerGananciaTotalHospital();
            //MessageBox.Show($"Ganancia Total del Hospital: {gananciaTotal:C}");
        }

        private void btnEspecialidadesPorGanancia_Click(object sender, EventArgs e)
        {
            //var formEspecialidadesGanancia = new EspecialidadesGananciaForm(gestorHospital);
            //formEspecialidadesGanancia.ShowDialog();
        }

        private void btnEspecialidadesPorPacientes_Click(object sender, EventArgs e)
        {
            //var formEspecialidadesPacientes = new EspecialidadesPacientesForm(gestorHospital);
            //formEspecialidadesPacientes.ShowDialog();
        }


    }
}
