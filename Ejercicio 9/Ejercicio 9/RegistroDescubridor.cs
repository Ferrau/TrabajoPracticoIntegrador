using ObservatorioDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class RegistroDescubridor: Form
    {
        public RegistroDescubridor()
        {
            InitializeComponent();
        }

        private void RegistroDescubridor_Load(object sender, EventArgs e)
        {

        }

        private Observatorio _obsRegistroDescubridor = new Observatorio();

        public Observatorio observatorioRegistroDescubridor
        {
            get { return _obsRegistroDescubridor; }
            set { _obsRegistroDescubridor = value; }
        }

        private void esPersonal_CheckedChanged(object sender, EventArgs e)
        {
            if(esPersonal.Checked == true)
            {
                txtLegajo.Visible = true;
                label3.Visible = true;
            }
            else
            {
                txtLegajo.Visible = false;
                label3.Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool ok = !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && dtFechaNacimiento.SelectionStart != null;
            Descubridor nuevoDescubridor = null;

            if (esPersonal.Checked == true)
            {
                if (ok && !string.IsNullOrWhiteSpace(txtLegajo.Text))
                {
                    nuevoDescubridor = new Personal(Convert.ToInt32(txtLegajo.Text), txtNombre.Text, txtApellido.Text, dtFechaNacimiento.SelectionStart);
                }
                else
                {
                    MessageBox.Show("Por favor, completar los espacios vacios", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ok)
                {
                    nuevoDescubridor = new Descubridor(txtNombre.Text, txtApellido.Text, dtFechaNacimiento.SelectionStart);
                }
                else
                {
                    MessageBox.Show("Por favor, completar los espacios vacios", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            _obsRegistroDescubridor.descubridores.Add(nuevoDescubridor);
            //ActualizarDescubridores();
            MostrarListBox(lstDescubridores, _obsRegistroDescubridor.descubridores);
        }

        /*
        public void ActualizarDescubridores()
        {
            lstDescubridores.DataSource = null;
            lstDescubridores.DataSource = _obsRegistroDescubridor.descubridores;
        }
        */
        
        public void MostrarListBox(ListBox nuevaList, object obj)
        {
            nuevaList.DataSource = null;
            nuevaList.DataSource = obj;
        }
        
    }
}
