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
    using System;
    using System.Windows.Forms;

    public partial class HistoriaClinicaForm : Form
    {
        private IGestorHospital gestorHospital;
        public HistoriaClinicaForm(IGestorHospital gestorHospital)
        {
          //  InitializeComponent();
            this.gestorHospital = gestorHospital;
        }



        private void btnVerHistoriaClinica_Click(object sender, EventArgs e)
        {
            // Lógica para ver la historia clínica de un paciente
        }

        private void btnVerHistoriaPorEspecialidad_Click(object sender, EventArgs e)
        {
            // Lógica para ver la historia clínica de un paciente por especialidad
        }
    }

}
