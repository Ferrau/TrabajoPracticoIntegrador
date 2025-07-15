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
    

    public partial class PacienteForm : Form
    {
        private IGestorHospital gestorHospital;

        public PacienteForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            // Lógica para guardar un nuevo paciente
        }
    }

}
