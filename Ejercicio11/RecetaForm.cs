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

    public partial class RecetaForm : Form
    {
        private IGestorHospital gestorHospital;

        public RecetaForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnGenerarReceta_Click(object sender, EventArgs e)
        {
            // Lógica para generar una receta médica
        }
    }

}
