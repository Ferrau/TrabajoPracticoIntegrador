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
    

    public partial class EspecialidadForm : Form
    {
        private IGestorHospital gestorHospital;

        public EspecialidadForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnGuardarEspecialidad_Click(object sender, EventArgs e)
        {
            // Lógica para guardar una nueva especialidad
        }
    }

}
