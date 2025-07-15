using HotelDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class FormHabitacion : Form
    {
        public FormHabitacion()
        {
            InitializeComponent();
        }
        private HotelTuristico _hotelAdmin = new HotelTuristico();

        public HotelTuristico HotelAdmin
        {
            get { return _hotelAdmin; }
            set { _hotelAdmin = value; }
        }

        public void MostrarGrilla(DataGridView dgv, Object obj)
        {
            dgv.DataSource = null;
            dgv.DataSource = obj;
            dgv.Refresh();
        }

        private void FormHabitacion_Load(object sender, EventArgs e)
        {
            InicializarTipoHabitaciones();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxTipoHabitacion.SelectedItem != null)
            {
                
                Habitacion habitacion;
                if (rbSinVistaAlMar.Checked)
                {
                    habitacion = new Habitacion((TipoHabitacion)cbxTipoHabitacion.SelectedItem);
                    _hotelAdmin.Habitaciones.Add(habitacion);
                    MostrarGrilla(dataGridView1, _hotelAdmin.Habitaciones);
                    MessageBox.Show("Habitación registrada sin vista al mar.");

                }
                else
                {
                    habitacion = new Habitacion((TipoHabitacion)cbxTipoHabitacion.SelectedItem, true);
                    _hotelAdmin.Habitaciones.Add(habitacion);
                    MostrarGrilla(dataGridView1, _hotelAdmin.Habitaciones);
                    MessageBox.Show("Habitación registrada con vista al mar.");
                }

            }
            
        }

        public void InicializarTipoHabitaciones()
        {
            cbxTipoHabitacion.DataSource = null;
            cbxTipoHabitacion.Items.Add(TipoHabitacion.Simple);
            cbxTipoHabitacion.Items.Add(TipoHabitacion.Doble);
            cbxTipoHabitacion.Items.Add(TipoHabitacion.Tiple);
            cbxTipoHabitacion.Items.Add(TipoHabitacion.Cuadruple);
        }
    }
}
