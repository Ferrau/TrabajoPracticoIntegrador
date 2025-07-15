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
    public partial class FormHuesped : Form
    {
        public FormHuesped()
        {
            InitializeComponent();
        }

        
        private HotelTuristico _hotelAdmin = new HotelTuristico();

        public HotelTuristico HotelAdmin
        {
            get { return _hotelAdmin; }
            set { _hotelAdmin = value; }
        }

        public void MostrarLista(ListBox list, Object obj)
        {
            list.DataSource = null;
            list.DataSource = obj;
        }
        private void FormHuesped_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarHuesped_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtDNI.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                DateTime fechaNaci = DateFechaNacim.SelectionStart;
                bool dniValido = long.TryParse(txtDNI.Text, out long dni) && 
                                 txtDNI.Text.Length == 8 && 
                                 txtDNI.Text.All(char.IsDigit);
                if (dniValido)
                {
                    Huesped nuevoHuesped = new Huesped(long.Parse(txtDNI.Text), txtNombre.Text, txtApellido.Text, fechaNaci);

                    if (nuevoHuesped.Edad > 18)
                    {
                        /*Verificamos si no existe en la lista de integrantes, entonce lo registramos*/
                        // Válido: puede reservar
                        bool Existe = _hotelAdmin.Huespedes.Any(h => h.DNI == nuevoHuesped.DNI);
                        if(!Existe){
                            _hotelAdmin.Huespedes.Add(nuevoHuesped);

                            //Actualizamos la lista de huespedes en el formulario principal
                            MostrarLista(listHuesped, _hotelAdmin.Huespedes);
                            MessageBox.Show("El Huesped se ha registrado correctamente.");

                        }
                        else
                        {
                            MessageBox.Show("El Huesped ya se encuentra registrado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Huesped debe ser mayor de edad (18 años)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                   MessageBox.Show("El formato del DNI ingresado no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                    
                    
        }
    }
}
