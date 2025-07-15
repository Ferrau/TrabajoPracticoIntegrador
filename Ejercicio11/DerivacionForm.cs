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

    public partial class DerivacionForm : Form
    {
        private IGestorHospital gestorHospital;

        public DerivacionForm(IGestorHospital gestorHospital)
        {
            InitializeComponent();
            this.gestorHospital = gestorHospital;
        }

        private void btnGuardarDerivacion_Click(object sender, EventArgs e)
        {
            // Lógica para guardar una nueva derivación
        }
    }

}
