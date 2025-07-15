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
    
    public partial class EspecialidadesGananciaForm : Form
    {
        private IGestorHospital gestorHospital;

        public EspecialidadesGananciaForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnListarEspecialidades_Click(object sender, EventArgs e)
        {
            // Lógica para listar especialidades por ganancia
        }
    }

}
