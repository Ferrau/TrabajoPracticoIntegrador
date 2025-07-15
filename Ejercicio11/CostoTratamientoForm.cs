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
    
    public partial class CostoTratamientoForm : Form
    {
        private IGestorHospital gestorHospital;

        public CostoTratamientoForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            // Lógica para calcular el costo total del tratamiento de un paciente
        }
    }

}
