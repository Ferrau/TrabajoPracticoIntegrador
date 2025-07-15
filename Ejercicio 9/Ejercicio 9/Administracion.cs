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
    public partial class Administracion: Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private Observatorio _obsAdministracion = new Observatorio();

        public Observatorio observatorioAdm
        {
            get { return _obsAdministracion; }
            set { _obsAdministracion = value; }
        }

        public double ConvertirDistancia(double distancia, string unidad)
        {
            double total = 0.0, kmEnAl = 9460730472580;
            if (unidad == "km")
            {
                total = distancia / kmEnAl;
            }
            else if (unidad == "al")
            {
                total = distancia * kmEnAl;
            }
            return total;
        }

        public double ConvertirTemperatura(double temperatura, string unidad)
        {
            double total = 0.0;
            if (unidad == "C")
            {
                total = (temperatura * 1.8) + 32;
            }
            else if (unidad == "F")
            {
                total = (temperatura - 32) * 0.55555555555555555555555555555556;
            }
            return total;
        }

        private void btnConvertirDistancia_Click(object sender, EventArgs e)
        {
            if(rdKilometros.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(txtKilometros.Text)
                    && double.TryParse(txtKilometros.Text, out double numero))
                {
                    double total = ConvertirDistancia(Convert.ToDouble(txtKilometros.Text), "km");
                    txtAñosLuz.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("La casilla de kilometros que estas intentando convertir esta vacia o no recibe un numero.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rdAñosLuz.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(txtAñosLuz.Text)
                    && double.TryParse(txtAñosLuz.Text, out double numero))
                {
                    double total = ConvertirDistancia(Convert.ToDouble(txtAñosLuz.Text), "al");
                    txtKilometros.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("La casilla de años luz que estas intentando convertir esta vacia o no recibe un numero.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConvertirTemperatura_Click(object sender, EventArgs e)
        {
            if(rdCelcius.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(txtCelcius.Text)
                    && double.TryParse(txtCelcius.Text, out double numero))
                {
                    double total = ConvertirTemperatura(Convert.ToDouble(txtCelcius.Text), "C");
                    txtFahrenheit.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("La casilla de celcius que estas intentando convertir esta vacia o no recibe un numero.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rdFahrenheit.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(txtFahrenheit.Text)
                    && double.TryParse(txtFahrenheit.Text, out double numero))
                {
                    double total = ConvertirTemperatura(Convert.ToDouble(txtFahrenheit.Text), "F");
                    txtCelcius.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("La casilla de Fahrenheit que estas intentando convertir esta vacia o no recibe un numero.", "Error de operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFiltrarPlaneta_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrarEstrella_Click(object sender, EventArgs e)
        {

        }

        private void rdAñosLuz_CheckedChanged(object sender, EventArgs e)
        {
            if(rdAñosLuz.Checked == true)
            {
                txtKilometros.Clear();
            }
        }

        private void rdKilometros_CheckedChanged(object sender, EventArgs e)
        {
            if(rdKilometros.Checked == true)
            {
                txtAñosLuz.Clear();
            }
        }

        private void rdCelcius_CheckedChanged(object sender, EventArgs e)
        {
            if(rdCelcius.Checked == true)
            {
                txtFahrenheit.Clear();
            }
        }

        private void rdFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if(rdFahrenheit.Checked == true)
            {
                txtCelcius.Clear();
            }
        }
    }
}
